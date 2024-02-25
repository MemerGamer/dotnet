using System.Collections.ObjectModel;

namespace labor1.Views;

public partial class ImageViewer
{
    private string _imgOfMikasa =
        "/run/media/hunor/Adatok/Egyetem/Egyetem 3. év/2. félév/dotnet/labor1/labor1/Resources/Images/mikasa.png";

    private string _imgOfEren = "./Resources/Eren.png";
    private string _imgOfArmin = "https://i.imgur.com/2KzAEFN.png";

    public ObservableCollection<string> Images { get; set; }

    public ImageViewer()
    {
        InitializeComponent();

        Images = new ObservableCollection<string>
        {
            _imgOfMikasa,
            _imgOfEren,
            _imgOfArmin,
        };

        this.BindingContext = this;
    }

    private void PrevButton_Clicked(object? sender, EventArgs e)
    {
        int newIndex = Carousel.Position - 1;
        Carousel.ScrollTo(newIndex, animate: true);
    }

    private void NextButton_Clicked(object? sender, EventArgs e)
    {
        int newIndex = Carousel.Position + 1;
        Carousel.ScrollTo(newIndex, animate: true);
    }
}