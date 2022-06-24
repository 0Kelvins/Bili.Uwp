﻿// Copyright (c) Richasy. All rights reserved.

using System;

namespace Bili.ViewModels.Uwp.Pgc
{
    /// <summary>
    /// PGC 播放页面视图模型.
    /// </summary>
    public sealed partial class PgcPlayerPageViewModel
    {
        /// <inheritdoc/>
        public void DisplayException(Exception exception)
        {
            IsError = true;
            var msg = GetErrorMessage(exception);
            ErrorText = $"{_resourceToolkit.GetLocaleString(Models.Enums.LanguageNames.RequestVideoFailed)}\n{msg}";
            LogException(exception);
        }

        private void DisplayFavoriteFoldersException(Exception exception)
        {
            IsFavoriteFoldersError = true;
            var msg = GetErrorMessage(exception);
            FavoriteFoldersErrorText = $"{_resourceToolkit.GetLocaleString(Models.Enums.LanguageNames.RequestVideoFavoriteFailed)}\n{msg}";
            LogException(exception);
        }
    }
}
