using System;
using UnityEngine;

namespace Code
{
    public sealed class Example : MonoBehaviour
    {
        private void Start()
        {
        }
        
        
        
        private void First()
        {
            int q, w, e; // bad
            int a = 2;
            a = 5;
        }
        
        private void Second()
        {
            int i = 2;
            long l = 2;
            float f = 2.123456789123456789f;
            double d = 2.123456789123456789d;
            decimal m = 2.123456789123456789m;
            char c = '1';
            string s = "Hello";
            bool b = true;

            l = i;
            i = (int)l;
            
            Debug.Log(i);
            Debug.Log(l);
            Debug.Log(f);
            Debug.Log(d);
            Debug.Log(m);
            Debug.Log(c);
            Debug.Log(s);
            Debug.Log(b);
        }
        
        private void Third()
        {
            float f = 2.123456789123456789f;
            Debug.LogError("player " + f + " hp");
            Debug.LogError(String.Format("player {0:C0} hp", f));
            Debug.LogError($"player {f:##.##} hp");
        }

        public string a;
        public string b;
        public string result;
        private void Fourth()
        {
            // + - * / %
           // int intA = (int)a;
           int intA = Convert.ToInt32(a);
           int intB = int.Parse(b);
           // int res = intA + intB;
           // result = res.ToString();
            result = (intA + intB).ToString();
            
            int doubleA = Convert.ToInt32(a);
            int doubleB = int.Parse(b);
            int res = doubleA / doubleB;
            result = res.ToString(); 
            
            // ++ --
            int i = 0;
            Debug.LogError(i++);
            
            // += -= *= /=

            float r = 7.9f;
            float y = r + 5;
            y += 5;
            Debug.LogError(y);
        }

        private void OnValidate()
        {
            Fourth();
        }

        private int[] _array = { 1, 2, 3, 4, 5 };
        private int _currentIndex = 0;
        
        private void Fifth()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _currentIndex++;
                int index = _currentIndex % _array.Length;
                Debug.LogError(_array[index]);
                Debug.LogWarning(index);
            }
        }
        
        private void Update()
        {
            Fifth();
        }
        
        private void Sixth()
        {
            int test = Test(5, 8);
            int max = Math.Max(2,5);
            int i = Mathf.Max(2,5);
        }

        private int Test(int a, int b) => a + b;
        
        private int Test2(int a, int b)
        {
            return a + b;
        }
    }
}
