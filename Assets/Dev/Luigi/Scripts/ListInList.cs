using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Pooling
{
    [Serializable]
    public class ListInList
    {
        [SerializeField]
        private List<GameObject> m_Object;
        public List<GameObject> Object
        {
            get { return m_Object; }
        }
    }
}
