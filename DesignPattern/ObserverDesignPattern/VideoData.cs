using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverDesignPattern
{
    internal class VideoData : Subject
    {
        private string title;
        private string description;
        private string fileName;

        public void SetTitle(string title)
        {
            this.title = title;
            getVideoDataChanged();
        }
        public void SetDescription(string description)
        {
            this.description = description;
            getVideoDataChanged();

        }
        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
            getVideoDataChanged();
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetFileName()
        {
            return fileName;
        }
        private void getVideoDataChanged()
        {
            notifyObservers(null);
        }
    }
}
