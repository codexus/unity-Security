using System;

namespace Codexus.Security
{
    /// <summary>
    /// Safe float is a secured value holder. Prevents from memory manipulations using additional offset
    /// </summary>
    public class SecuredFloat
    {
        private readonly float m_offset;
        private readonly float m_value;

        /// <summary>
        /// Actual float value.
        /// </summary>
        public float value
        {
            get { return m_value - m_offset; }
        }

        public SecuredFloat(float value = 0)
        {
            m_offset = UnityEngine.Random.Range(-1000, +1000);
            m_value = value + m_offset;
        }

        #region Operators

        public static SecuredFloat operator +(SecuredFloat f1, SecuredFloat f2)
        {
            return new SecuredFloat(f1.value + f2.value);
        }

        public static SecuredFloat operator -(SecuredFloat f1, SecuredFloat f2)
        {
            return new SecuredFloat(f1.value - f2.value);
        }

        public static SecuredFloat operator *(SecuredFloat f1, SecuredFloat f2)
        {
            return new SecuredFloat(f1.value * f2.value);
        }

        public static SecuredFloat operator /(SecuredFloat f1, SecuredFloat f2)
        {
            return new SecuredFloat(f1.value / f2.value);
        }

        public static SecuredFloat operator ++(SecuredFloat f1)
        {
            return new SecuredFloat(f1.value + 1);
        }

        public static bool operator >=(SecuredFloat f1, SecuredFloat f2)
        {
            return f1.value >= f2.value;
        }

        public static bool operator <=(SecuredFloat f1, SecuredFloat f2)
        {
            return f1.value <= f2.value;
        }

        public static bool operator ==(SecuredFloat f1, SecuredFloat f2)
        {
            return f1.value == f2.value;
        }

        public static bool operator !=(SecuredFloat f1, SecuredFloat f2)
        {
            return f1.value != f2.value;
        }

        #endregion

        #region Overrides

        public override bool Equals(System.Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ( value == (obj as SecuredFloat).value);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString();
        }

        #endregion

    }

}