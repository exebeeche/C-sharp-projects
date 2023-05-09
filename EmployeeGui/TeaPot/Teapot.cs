using System;
using System.Threading;
using System.Windows.Forms;

namespace TeaPot {
    public enum Model {
        Vitek,
        Bosch,
        Redmond,
        Xiaomi,
        Polaris
    }

    public class TemperatureEventArgs : EventArgs {
        public int Temp { get; set;  }
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

        public delegate void ModelChangedEventHandler();
        public event ModelChangedEventHandler ModelChanged;
        public Teapot(int temp) {
        }

        public void ChooseModel(ComboBox comboBox) {
            /*comboBox.Items.AddRange(Enum.GetNames(typeof(Model)));
            comboBox.SelectedIndex = 1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;*/            
            
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
            ModelChanged?.Invoke();
        }
        private void SwitchModel(float newVolume) {
            maxVolume = newVolume;
            currentTemp = 20;
            currentVolume = 0;
        }
        public float maxVolume { get; private set; }
        float currentVolume;
        public int maxTemp = 100;
        int currentTemp = 20;
        public Model Model;
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
