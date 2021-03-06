﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   StorageSelectionFormViewModel.cs
// </summary>
// ***********************************************************************

namespace STM.UI.Forms.StorageSelection
{
    public class StorageSelectionFormViewModel
    {
        public string FileName { get; set; }
        public StorageSelectionFormMode? Mode { get; set; }
        public string NewFileName { get; set; }
        public string Password { get; set; }
        public bool? SavePassword { get; set; }
    }
}
