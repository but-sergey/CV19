using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Window title

        private string _Title = "Анализ статистики COVID-19";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
            //{
            //    if (Equals(_title, value)) return;
            //    _title = value;
            //    OnPropertyChanged();
            //}
        }

        #endregion
    }
}
