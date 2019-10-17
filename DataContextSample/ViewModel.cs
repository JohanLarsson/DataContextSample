namespace DataContextSample
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModel : INotifyPropertyChanged
    {
        private int left;
        private int right;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Sum => this.Left + this.Right;

        public int Left
        {
            get => this.left;
            set
            {
                if (value == this.left)
                {
                    return;
                }

                this.left = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.Sum));
            }
        }

        public int Right
        {
            get => this.right;
            set
            {
                if (value == this.right)
                {
                    return;
                }

                this.right = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.Sum));
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
