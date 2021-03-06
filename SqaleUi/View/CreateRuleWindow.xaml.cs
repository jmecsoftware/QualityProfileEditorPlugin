﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateRuleWindow.xaml.cs" company="Copyright © 2014 jmecsoftware">
//     Copyright (C) 2014 [jmecsoftware, jmecsoftware2014@tekla.com]
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License
// as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details. 
// You should have received a copy of the GNU Lesser General Public License along with this program; if not, write to the Free
// Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// --------------------------------------------------------------------------------------------------------------------

namespace SqaleUi
{
    using SqaleUi.ViewModel;

    /// <summary>
    ///     Interaction logic for CreateRuleWindow.xaml
    /// </summary>
    public partial class CreateRuleWindow
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRuleWindow"/> class.
        /// </summary>
        /// <param name="createRulesModel">
        /// The create rules model.
        /// </param>
        public CreateRuleWindow(CreateRuleViewModel createRulesModel)
        {
            this.InitializeComponent();

            this.DataContext = createRulesModel;
        }

        #endregion
    }
}