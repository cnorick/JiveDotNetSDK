﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.Pokeshot.JiveSdk.Models.Dto
{
    public class JiveDEAActionObject
    {
        public string @class { get; set; }
        public string objectType { get; set; }
        public int objectId { get; set; }
        public string objectHash { get; set; }
        public bool isDataAvailable { get; set; }
        public List<string> tags { get; set; }
        public string subject { get; set; }
        public int creationDate { get; set; }
        public int modifiedDate { get; set; }
        public int authorId { get; set; }
        public int containerId { get; set; }
        public string containerType { get; set; }
        public bool isVisibleToPartner { get; set; }
        public string status { get; set; }
        public string url { get; set; }
        public string fullPath { get; set; }
        public string normalizedPath { get; set; }
        public string combinedObjectTypeId { get; set; }

    }
}
