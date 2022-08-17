using System.Windows;

namespace CustomControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly double xpoint;
        private readonly double ypoint;
        private const double lineWidth = 100;
        private object dragObject;
        private Point offSet, startPoint;
        public MainWindow()
        {
            InitializeComponent();
            //lineBtn.Click += LineBtn_Click;
            //mfcBtn.Click += MfcBtn_Click;
            //valveBtn.Click += ValveBtn_Click;
            //xpoint = shapeCanvas.Width / 2;
            //ypoint = shapeCanvas.Height / 2;
            //shapeCanvas.PreviewMouseMove += ShapeCanvas_PreviewMouseMove;
            //shapeCanvas.PreviewMouseLeftButtonUp += ShapeCanvas_PreviewMouseLeftButtonUp;
        }

        //private void ValveBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    ValveControl valveControl = new ValveControl();
        //    //mFCControl.Background = Brushes.Green;
        //    Canvas.SetLeft(valveControl, xpoint);
        //    Canvas.SetTop(valveControl, ypoint);
        //    valveControl.PreviewMouseLeftButtonDown += ValveControl_PreviewMouseLeftButtonDown; ;
        //    shapeCanvas.Children.Add(valveControl);
        //}

        //private void ValveControl_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var valveControl = sender as ValveControl;
        //    dragObject = sender as ValveControl;
        //    offSet = e.GetPosition(this);
        //    startPoint.X = Canvas.GetLeft(valveControl);
        //    startPoint.Y = Canvas.GetTop(valveControl);
        //}

        //private void MfcBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    MFCControl mFCControl = new MFCControl();
        //    mFCControl.Background = Brushes.Green;
        //    Canvas.SetLeft(mFCControl, xpoint);
        //    Canvas.SetTop(mFCControl, ypoint);
        //    mFCControl.PreviewMouseLeftButtonDown += MFCControl_PreviewMouseLeftButtonDown;
        //    shapeCanvas.Children.Add(mFCControl);
        //}

        //private void MFCControl_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var mFCControl = sender as MFCControl;
        //    dragObject = sender as MFCControl;
        //    offSet = e.GetPosition(this);
        //    startPoint.X = Canvas.GetLeft(mFCControl);
        //    startPoint.Y = Canvas.GetTop(mFCControl);
        //}

        //private void ShapeCanvas_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    //if (dragObject != null)
        //    //{
        //    //    var position = e.GetPosition(this);
        //    //    if (position.X > shapeCanvas.Width
        //    //        || position.Y > shapeCanvas.Height
        //    //        || position.X < 0
        //    //        || position.Y < 0)
        //    //        return;
        //    //    var line = dragObject as Line;
        //    //    double xValue = position.X - offSet.X;
        //    //    double yValue = position.Y - offSet.Y;
        //    //    line.X1 += xValue;
        //    //    line.Y1 += yValue;
        //    //    line.X2 += xValue;
        //    //    line.Y2 += yValue;
        //    //}
        //    dragObject = null;
        //}

        //private void ShapeCanvas_PreviewMouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        if (dragObject == null)
        //            return;
        //        var position = e.GetPosition(this);
        //        if (position.X > shapeCanvas.Width
        //            || position.Y > shapeCanvas.Height
        //            || position.X < 0
        //            || position.Y < 0)
        //            return;

        //        double xValue = position.X - offSet.X;
        //        double yValue = position.Y - offSet.Y;

        //        if (dragObject is Line)
        //        {
        //            var line = dragObject as Line;
        //            line.X1 = startPoint.X + xValue;
        //            line.Y1 = startPoint.Y + yValue;
        //            line.X2 = startPoint.X + lineWidth;
        //            line.Y2 = startPoint.Y + lineWidth;
        //        }
        //        else if(dragObject is MFCControl)
        //        {
        //            var mFCControl = dragObject as MFCControl;
        //            Canvas.SetLeft(mFCControl, startPoint.X + xValue);
        //            Canvas.SetTop(mFCControl, startPoint.Y + yValue);
        //        }
        //        else if (dragObject is ValveControl)
        //        {
        //            var valveControl = dragObject as ValveControl;
        //            Canvas.SetLeft(valveControl, startPoint.X + xValue);
        //            Canvas.SetTop(valveControl, startPoint.Y + yValue);
        //        }
        //    }
        //}

        //private void LineBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    Line newLine = new()
        //    {
        //        X1 = xpoint,
        //        Y1 = ypoint,
        //        X2 = xpoint + lineWidth,
        //        Y2 = ypoint + lineWidth,
        //        Stroke = Brushes.Black,
        //        StrokeThickness = 2
        //    };
        //    newLine.PreviewMouseLeftButtonDown += NewLine_PreviewMouseLeftButtonDown;
        //    shapeCanvas.Children.Add(newLine);
        //}

        //private void NewLine_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var line = sender as Line;
        //    dragObject = sender as Line;
        //    offSet = e.GetPosition(this);
        //    startPoint.X = line.X1;
        //    startPoint.Y = line.Y1;
        //}
    }
}
