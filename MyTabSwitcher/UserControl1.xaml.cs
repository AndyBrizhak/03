using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTabSwitcher
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        //properties

        /// <summary>
        /// The field that determines the hiding status of the Previous button
        /// </summary>
        private bool bHidebtnPrevious = false;
        /// <summary>
        /// The field that determines the hiding status of the Next button
        /// </summary>
        private bool bHideBtnNext = false;

        /// <summary>
        /// The property that determines the hiding status of the Previous button
        /// </summary>
        public bool IsHidebtnPrevious
        {
            get { return bHidebtnPrevious; }
            set
            {
                bHidebtnPrevious = value;
                SetButtons(); 
            }
        }

        /// <summary>
        /// The property that determines the hiding status of the Next button
        /// </summary>
        public bool IsHideBtnNext
        {
            get { return bHideBtnNext; }
            set
            {
                bHideBtnNext = value;
                SetButtons(); 
            }
        }

        //methods

        /// <summary>
        /// The method that is responsible for rendering the buttons.
        /// </summary>
        private void BtnNextTruebtnPreviousFalse()
        {
            btnNext.Visibility = Visibility.Hidden;
            btnPrevious.Visibility = Visibility.Visible;
            btnPrevious.Width = 229;
            btnNext.Width = 0;
            btnPrevious.HorizontalAlignment = HorizontalAlignment.Stretch;
        }

        /// <summary>
        /// The method that is responsible for rendering the buttons.
        /// </summary>
        private void btnPreviousTrueBtnNextFalse()
        {
            btnPrevious.Visibility = Visibility.Hidden;
            btnNext.Visibility = Visibility.Visible;
            btnNext.Width = 229;
            btnPrevious.Width = 0;
            btnNext.HorizontalAlignment = HorizontalAlignment.Stretch;
        }


        /// <summary>
        /// The method that is responsible for rendering the buttons.
        /// </summary>
        private void btnPreviousFalseBtnNextFalse()
        {
            btnNext.Visibility = Visibility.Visible;
            btnPrevious.Visibility = Visibility.Visible;
            btnNext.Width = 115;
            btnPrevious.Width = 114;
        }

        /// <summary>
        /// The method that is responsible for rendering the buttons.
        /// </summary>
        private void btnPreviousTrueBtnNextTrue()
        {
            btnPrevious.Visibility = Visibility.Hidden;
            btnNext.Visibility = Visibility.Hidden;
        }

       
        /// <summary>
        /// The method that is responsible for rendering the buttons.
        /// </summary>
        private void SetButtons()
        {
            if (bHidebtnPrevious && bHideBtnNext) btnPreviousTrueBtnNextTrue();
            else if (!bHideBtnNext && !bHidebtnPrevious) btnPreviousFalseBtnNextFalse();
            else if (bHideBtnNext && !bHidebtnPrevious) BtnNextTruebtnPreviousFalse();
            else if (!bHideBtnNext && bHidebtnPrevious) btnPreviousTrueBtnNextFalse();
        }
    }
}
