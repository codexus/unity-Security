using System;

namespace Codexus.Security
{
    /// <summary>
    /// Safe float is a secured value holder. Prevents from memory manipulations using additional offset
    /// </summary>
    public class SecuredInt
    {
        private readonly int m_offset;
        private readonly int m_value;

        /// <summary>
        /// Actual int value.
        /// </summary>
        public int value
        {
            get { return m_value - m_offset; }
        }

        public SecuredInt(int value = 0)
        {
            m_offset = UnityEngine.Random.Range(-1000, +1000);
            m_value = value + m_offset;
        }

        #region Operators

        public static SecuredInt operator +(SecuredInt f1, SecuredInt f2)
        {
            return new SecuredInt(f1.value + f2.value);
        }

        public static SecuredInt operator -(SecuredInt f1, SecuredInt f2)
        {
            return new SecuredInt(f1.value - f2.value);
        }

        public static SecuredInt operator *(SecuredInt f1, SecuredInt f2)
        {
            return new SecuredInt(f1.value * f2.value);
        }

        public static SecuredInt operator /(SecuredInt f1, SecuredInt f2)
        {
            return new SecuredInt(f1.value / f2.value);
        }

        public static SecuredInt operator ++(SecuredInt f1)
        {
            return new SecuredInt(f1.value + 1);
        }

        public static bool operator >=(SecuredInt f1, SecuredInt f2)
        {
            return f1.value >= f2.value;
        }

        public static bool operator <=(SecuredInt f1, SecuredInt f2)
        {
            return f1.value <= f2.value;
        }

        public static bool operator ==(SecuredInt f1, SecuredInt f2)
        {
            return f1.value == f2.value;
        }

        public static bool operator !=(SecuredInt f1, SecuredInt f2)
        {
            return f1.value != f2.value;
        }
        
        public static implicit operator int(SecuredInt securedInt)
        {
          return securedInt.value;
        }
    
        public static implicit operator SecuredInt(int value)
        {
            return new SecuredInt(value);
        }

        #endregion

        #region Overrides
        public override bool Equals(System.Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return (value == (obj as SecuredInt).value);
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
