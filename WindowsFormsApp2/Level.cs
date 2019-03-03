using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Level
    {
        private String name;
        private int smallBlind = 0;
        private int bigBlind = 0;
        private int ante = 0;
        private int time = 0;

        public Level(string n, int s, int b, int a, int t)
        {
            this.name = n;
            this.smallBlind = s;
            this.bigBlind = b;
            this.ante = a;
            this.time = t;
        }

        public string LevelName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

            public int BigBlind
        {
            get
            {
                return this.bigBlind;
            }
            set
            {
                this.bigBlind = value;
            }
        }

            public int SmallBlind
        {
            get
            {
                return this.smallBlind;
            }
            set
            {
                this.smallBlind = value;
            }

        }

        public int Ante
        {
            get
            {
                return this.ante;
            }
            set
            {
                this.ante = value;
            }

        }

        public int Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }

        }

    }

    }

