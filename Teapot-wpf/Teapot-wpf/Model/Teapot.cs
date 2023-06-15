using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Teapot_wpf.Model {
    public enum Model {
        Vitek,
        Bosch,
        Redmond,
        Xiaomi,
        Polaris
    }

    public class TemperatureEventArgs : EventArgs {
        public int Temp { get; set; }
        public TemperatureEventArgs(int temp) {
            Temp = temp;
        }
    }

    public class VolumeEventArgs : EventArgs {
        public float Volume { get; set; }
        public VolumeEventArgs(float volume) {
            Volume = volume;
        }
    }
    public class Teapot {
        public delegate void TempChangedEventHandler(object sender, TemperatureEventArgs e);
        public event TempChangedEventHandler TempChanged;

        public delegate void VolumeChangedEventHandler(object sender, VolumeEventArgs e);
        public event VolumeChangedEventHandler VolumeChanged;

        public delegate void TempMaxEventHandler();
        public event TempMaxEventHandler TempMax;

        public delegate void VolumeMaxEventHandler();
        public event VolumeMaxEventHandler VolumeMax;

        public delegate void ModelChangedEventHandler(object Sender, EventArgs e);
        public event ModelChangedEventHandler ModelChanged;        

        public Teapot() {
        }

        public void ChooseModel(ComboBox comboBox) {

            Model = (Model)comboBox.SelectedIndex;

            switch(this.Model) {
                case Model.Vitek:
                    SwitchModel(1.8f);
                    break;
                case Model.Bosch:
                    SwitchModel(1.7f);
                    break;
                case Model.Redmond:
                    SwitchModel(1.9f);
                    break;
                case Model.Xiaomi:
                    SwitchModel(1.5f);
                    break;
                case Model.Polaris:
                    SwitchModel(2.0f);
                    break;
                default:
                    SwitchModel(1.8f);
                    break;
            };
            ModelChanged?.Invoke(this, new EventArgs());
        }
        private void SwitchModel(float newVolume) {
            maxVolume = newVolume;
            currentTemp = 20;
            currentVolume = 0;
        }
        public float maxVolume { get; private set; }
        public float currentVolume { get; private set; }
        public int maxTemp = 100;
        public int currentTemp { get; private set; } = 20;
        
        public Model Model { get; set; }
        public void ChangeVolume(object sender, EventArgs e) {
            if(currentVolume < maxVolume) {
                currentVolume += 0.1f;
                VolumeChanged?.Invoke(this, new VolumeEventArgs(currentVolume));
            } else {
                VolumeMax?.Invoke();
            }
        }
        public void ChangeTemp(object sender, EventArgs e) {
            if(currentTemp < maxTemp) {
                currentTemp += 10;
                TempChanged?.Invoke(this, new TemperatureEventArgs(currentTemp));
            } else {
                TempMax?.Invoke();
            }
        }

    }
}
