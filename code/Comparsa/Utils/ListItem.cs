using System;

namespace Comparsa
{

    public class ListItem
    {
        private string m_Display;
        private int m_Value;

        public ListItem(string Display, int Value)
        {
            m_Display = Display;
            m_Value = Value;
        }

        public string Display
        {
            get { return m_Display; }
            set { m_Display = value; }
        }

        public int Value
        {
            get { return m_Value; }
            set { m_Value = value;  }
        }

    }

}