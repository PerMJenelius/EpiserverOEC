﻿using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverOEC.Models
{
    [ContentType]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        [ImageDescriptor(Width = 50, Height = 50)]
        public override Blob Thumbnail
        {
            get { return base.Thumbnail; }
            set { base.Thumbnail = value; }
        }

        public virtual string AlternativeText { get; set; }
    }
}