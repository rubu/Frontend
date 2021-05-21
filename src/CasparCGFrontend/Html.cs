using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class Html : INotifyPropertyChanged
    {
        public Html()
        {
        }

        private Boolean? enableGpu = null;
        [XmlElement(ElementName = "enable-gpu")]
        public Boolean EnableGpu
        {
            get { return this.enableGpu ?? false; }
            set { this.enableGpu = value; NotifyChanged("EnableGpu"); }
        }

        public bool ShouldSerializeEnableGpu()
        {
            return this.enableGpu != null;
        }

        public bool IsOnlyDefaultValues()
        {
            return (this.enableGpu == null || this.enableGpu == false);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
}
}
