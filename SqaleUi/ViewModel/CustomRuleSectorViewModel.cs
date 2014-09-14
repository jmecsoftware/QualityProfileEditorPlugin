﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomRuleSectorViewModel.cs" company="Copyright © 2014 Tekla Corporation. Tekla is a Trimble Company">
//     Copyright (C) 2013 [Jorge Costa, Jorge.Costa@tekla.com]
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

namespace SqaleUi.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Windows;

    using ExtensionTypes;

    using GalaSoft.MvvmLight.Command;

    using PropertyChanged;

    /// <summary>
    ///     The custom rule sector view model.
    /// </summary>
    [ImplementPropertyChanged]
    public class CustomRuleSectorViewModel
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuleSectorViewModel"/> class.
        /// </summary>
        public CustomRuleSectorViewModel()
        {
            this.CustomRules = new ObservableCollection<Rule>();
            this.SelectRuleCommand = new RelayCommand<Window>(this.ExecuteSelectRule, this.CanExecute);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the custom rules.
        /// </summary>
        public ObservableCollection<Rule> CustomRules { get; set; }

        /// <summary>
        /// Gets or sets the select rule command.
        /// </summary>
        public RelayCommand<Window> SelectRuleCommand { get; set; }

        /// <summary>
        /// Gets or sets the selected rule.
        /// </summary>
        public Rule SelectedRule { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// The can execute.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool CanExecute(Window arg)
        {
            return this.SelectedRule != null;
        }

        /// <summary>
        /// The execute select rule.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        private void ExecuteSelectRule(Window obj)
        {
            obj.Close();
        }

        #endregion
    }
}