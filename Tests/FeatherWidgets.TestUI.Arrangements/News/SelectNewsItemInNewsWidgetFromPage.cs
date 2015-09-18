﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeatherWidgets.TestUtilities.CommonOperations;
using Telerik.Sitefinity.TestArrangementService.Attributes;
using Telerik.Sitefinity.TestUI.Arrangements.Framework;
using Telerik.Sitefinity.TestUtilities.CommonOperations;

namespace FeatherWidgets.TestUI.Arrangements
{
    /// <summary>
    /// SelectNewsItemInNewsWidgetFromPage arrangement class.
    /// </summary>
    public class SelectNewsItemInNewsWidgetFromPage : TestArrangementBase
    {
        /// <summary>
        /// Server side set up.
        /// </summary>
        [ServerSetUp]
        public void SetUp()
        {
            Guid pageId = ServerOperations.Pages().CreatePage(PageName);
            ServerOperations.News().CreatePublishedNewsItem(NewsTitle1, NewsContent1, null);
            ServerOperations.News().CreatePublishedNewsItem(NewsTitle2, NewsContent2, null);
            ServerOperationsFeather.Pages().AddNewsWidgetToPage(pageId);
        }

        /// <summary>
        /// Tears down.
        /// </summary>
        [ServerTearDown]
        public void TearDown()
        {
            ServerOperations.Pages().DeleteAllPages();
            ServerOperations.News().DeleteAllNews();
        }
        
        private const string PageName = "News";
        private const string NewsContent1 = "News content1";
        private const string NewsTitle1 = "NewsTitle1";
        private const string NewsContent2 = "News content2";
        private const string NewsTitle2 = "NewsTitle2";
    }
}
