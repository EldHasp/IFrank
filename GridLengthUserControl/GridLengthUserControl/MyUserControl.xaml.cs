using System.Windows;
using System.Windows.Controls;

namespace GridLengthUserControl
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        public GridLength IconColumnWidth
        {
            get { return (GridLength)GetValue(IconColumnWidthProperty); }
            set { SetValue(IconColumnWidthProperty, value); }
        }

        public static readonly DependencyProperty IconColumnWidthProperty =
            DependencyProperty.Register(nameof(IconColumnWidth),
                                        typeof(GridLength),
                                        typeof(MyUserControl),
                                        new PropertyMetadata(new GridLength(0),
                                                             new PropertyChangedCallback(SetIconColumnWidth)));

        public static void SetIconColumnWidth(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MyUserControl target = (MyUserControl)d;
            target.MainGrid.ColumnDefinitions[0].Width = ((GridLength)e.NewValue);
        }
    }
}
