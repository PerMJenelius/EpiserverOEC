using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OEC_webb.Models
{
    public class SQLQuery
    {
        const string CON_STR = "Data Source=sc-sql-d01;Initial Catalog=OEC-webb-DB;Integrated Security=False;User ID=Connection-Oec-User;Password='Adm4utvsun'";
        static SqlConnection connection = new SqlConnection(CON_STR);

        static void Main(string[] args)
        {
        }

        public static List<Bid> GetAllBids()
        {
            var bids = new List<Bid>();

            lock (bids)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = $"select * from BidsPerItem";
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        bids.Add(new Bid(Convert.ToInt32(dr["ItemID"]), dr["BidderName"].ToString(), Convert.ToInt32(dr["BidAmount"]), Convert.ToDateTime(dr["BidTime"])));
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }
            }

            return bids;
        }

        public static BidHistory GetBidHistory(int id)
        {
            var bidData = new List<Bid>();
            var bidHist = new BidHistory();
            var importedFields = new List<string>();

            lock (bidHist)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = $"select * from BidsPerItem where itemID = {id}";
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        bidData.Add(new Bid(Convert.ToInt32(dr["ItemID"]), dr["BidderName"].ToString(), Convert.ToInt32(dr["BidAmount"]), Convert.ToDateTime(dr["BidTime"])));
                    }

                    bidHist.HighestBid = bidData.Max(b => b.BidAmount);
                    bidHist.LatestBidder = bidData.FirstOrDefault(b => b.BidAmount == bidHist.HighestBid).BidderName;

                    foreach (var bid in bidData)
                    {
                        ++bidHist.NumberOfBids;
                    }
                }
                catch (Exception)
                {
                    bidHist.HighestBid = 0;
                    bidHist.NumberOfBids = 0;
                    bidHist.LatestBidder = String.Empty;
                }
                finally
                {
                    connection.Close();
                }
            }

            bidHist.ItemId = id;

            return bidHist;
        }

        public static string AddBidToDB(BidVM bm)
        {
            bool success = false;
            string errorMessage = String.Empty;
            int itemId = 0;
            string newBidder = String.Empty;
            int bidAmount = 0;
            DateTime bidTime = DateTime.MinValue;

            try
            {
                itemId = bm.ItemId;
                newBidder = bm.NewBidder;
                bidAmount = bm.BidAmount;
                bidTime = DateTime.Now;
                BidHistory bidHistory = GetBidHistory(itemId);
                int highestBid = bidHistory.HighestBid;

                //Check if the proposed bid is at least 3% larger than the present highest bid
                if (bidAmount >= (1.03 * highestBid) && bidAmount <= (10 * highestBid))
                {
                    success = true;
                }
                else if (highestBid == 0)
                {
                    success = true;
                }
                else
                {
                    errorMessage = "Bjud mellan 103 och 1000 procent av senaste bud";
                }

                //Sanitize database input
                for (int i = 0; i < newBidder.Length; i++)
                {
                    if (newBidder[i].ToString() == "'" || newBidder[i].ToString() == "=" || newBidder[i].ToString() == ";")
                    {
                        success = false;
                        errorMessage = "Ogiltigt tecken i namnet";
                    }

                    if (newBidder[i].ToString() == "-" && newBidder[i + 1].ToString() == "-")
                    {
                        success = false;
                        errorMessage = "Ogiltigt tecken i namnet";
                    }
                }
            }
            catch (Exception)
            {
                success = false;
                errorMessage = "Fel vid kontakt med servern";
            }

            if (success)
            {
                lock (bm)
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = $"insert into BidsPerItem (ItemID, BidderName, BidAmount, BidTime) values ('{itemId}', '{newBidder}', '{bidAmount}', '{bidTime}')";

                        int nrRows = command.ExecuteNonQuery();

                        if (nrRows > 0)
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                        errorMessage = "Fel vid kontakt med servern. Prova igen senare";
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return errorMessage;
        }

        public static bool DeleteBidFromDB(int id, int amount)
        {
            bool success = false;
            var bidData = new List<Bid>();

            lock (bidData)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = $"select * from BidsPerItem where ItemID = {id} and BidAmount= {amount}";
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        bidData.Add(new Bid(Convert.ToInt32(dr["ItemID"]), dr["BidderName"].ToString(), Convert.ToInt32(dr["BidAmount"]), Convert.ToDateTime(dr["BidTime"])));
                    }
                }
                catch (Exception)
                {
                    success = false;
                }
                finally
                {
                    connection.Close();
                }
            }

            if (bidData.Count == 1)
            {
                lock (bidData)
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = $"delete from BidsPerItem where ItemID = {id} and BidAmount = {amount}";
                        int nrRows = command.ExecuteNonQuery();

                        if (nrRows > 0)
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return success;
        }
    }
}