﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combination1.controls
{
    //FG communication view model
    class FGCommunicationViewModel : INotifyPropertyChanged
    {
        FGCommunicationModel m;

        public FGCommunicationViewModel(FGCommunicationModel m)
        {
            this.m = m;
            this.m.PropertyChanged +=
               delegate (Object sender, PropertyChangedEventArgs e)
               {
                   NotifyPropertyChanged("VM_" + e.PropertyName);
               };
        }

        public string VM_StatusText
        {
            get
            {
                return this.m.StatusText;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public void setTimeSliderModel(timeSliderModel o)
        {
            this.m.setTimeSliderModel(o);
        }

        public void exit()
        {
            this.m.exit();
        }
    }
}
