using System;
using System.ComponentModel;
using Teapot_wpf.Model;
using Teapot_wpf.View;

namespace Teapot_wpf.Presenter {
    public class Present : INotifyPropertyChanged {
        public Present(Teapot teapot, MainWindow window) {
            Teapot = teapot;
            View = window;
            Teapot.ModelChanged += UpdateTPInfo;
            Teapot.TempChanged += UpdateTPInfo;
            Teapot.VolumeChanged += UpdateTPInfo;            
        }        

        private Teapot Teapot { get; set; }
        private MainWindow View { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void UpdateTPInfo(object Sender, EventArgs e) {
            View.TextBoxVolumeText = Teapot.currentVolume.ToString();
            View.TextBoxTempText = Teapot.currentTemp.ToString();
            View.TextBoxMaxVolumeText = Teapot.maxVolume.ToString();


            /*if (Sender is Teapot teapot) {
                if (e is TemperatureEventArgs tempArgs) {
                    Teapot. = tempArgs.Temp;
                }
                if (e is VolumeEventArgs volumeArgs) {
                    Teapot.maxTemp = volumeArgs.Volume;
                }
            }*/
        }
    }
}
