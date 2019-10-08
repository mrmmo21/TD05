using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TD05
{
    class PersonHMI : IPerson, ICloneable
    {

        private Person personne;

        public PersonHMI(Person p)
        {
            this.personne = p;
        }

        public string Address { get => ((IPerson)personne).Address; set => ((IPerson)personne).Address = value; }
        public string EMail { get => ((IPerson)personne).EMail; set => ((IPerson)personne).EMail = value; }
        public string FirstName { get => ((IPerson)personne).FirstName; set => ((IPerson)personne).FirstName = value; }
        public Gender Gender { get => ((IPerson)personne).Gender; set => ((IPerson)personne).Gender = value; }
        public string LastName { get => ((IPerson)personne).LastName; set => ((IPerson)personne).LastName = value; }
        public string Phone { get => ((IPerson)personne).Phone; set => ((IPerson)personne).Phone = value; }

        public Person P { get => this.personne; }

        public object Clone()
        {
            return ((IPerson)personne).Clone();
        }
        public BitmapImage Icon
        {
            get
            {
                BitmapImage img;
                if (this.Gender.Equals(Gender.FEMALE))
                {
                    img = new BitmapImage(new Uri("pack://siteoforigin:,,,/images/contact_f.png"));
                }
                else if (this.Gender.Equals(Gender.MALE))
                {
                    img = new BitmapImage(new Uri("pack://siteoforigin:,,,/images/contact_m.png"));
                }
                else
                    img = new BitmapImage(new Uri("pack://siteoforigin:,,,/images/contact_x.png"));
                return img;
            }
        }

        public bool IsMale
        {
            get { return Gender == Gender.MALE; }
            set { if (value) Gender = Gender.MALE; }
        }
        public bool IsFemale
        {
            get { return Gender == Gender.FEMALE; }
            set { if (value) Gender = Gender.FEMALE; }
        }

        public void Copy(Person p)
        {
            ((IPerson)personne).Copy(p);
        }
    }
}