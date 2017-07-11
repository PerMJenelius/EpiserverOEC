using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "BreadCrumb", GUID = "9314b2d0-f605-4ccc-9b2e-cea1c9f08a69", Description = "")]
    public class BreadCrumb : BlockData
    {
    }
}