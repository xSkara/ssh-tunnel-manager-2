﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   IStorageSelectionForm.cs
// </summary>
// ***********************************************************************

using STM.Core;
using STM.UI.Framework.Mvc;

namespace STM.UI.Forms.StorageSelection
{
    public interface IStorageSelectionForm : IDialog<StorageSelectionFormController>
    {
        bool DoValidate();
        void Render(StorageSelectionFormViewModel viewModel);
        EncryptedStorageParameters Collect();
        void RenderError(string errorText);
    }
}