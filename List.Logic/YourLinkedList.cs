using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace Lists.Logic
{
    public class YourLinkedList<T>
    {
        private DoubleNode<Car>? _first;

        private DoubleNode<Car>? _last;

        public YourLinkedList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }


        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }


        public void Add(Car item)
        {
            var node = new DoubleNode<Car>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }

        public string GetBrand(string brand)
        {
            
            var output = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                if (brand.Equals(pointer.Data?.Brand))
                {
                    output += $"{pointer.Data}\n";
                }
                pointer = pointer.Right;
            }
            return output; 


        }

        public string GetModel(string model)
        {

            var output = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                if (model.Equals(pointer.Data?.Model))
                {
                    output += $"{pointer.Data}\n";
                }
                pointer = pointer.Right;
            }
            return output;


        }

        public string GetYear(int lower, int upper)
        {

            var output = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                if (lower == pointer.Data?.Year && upper == pointer.Data.Year)
                {
                    output += $"{pointer.Data}\n";

                }
                pointer = pointer.Right;
            }
            return output;


        }

        public string GetPrice(decimal lower, decimal upper)
        {

            var output = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                if (lower == pointer.Data?.Price && upper == pointer.Data.Price)
                {
                    output += $"{pointer.Data}\n";

                }
                pointer = pointer.Right;
            }
            return output;


        }

     


    }


}


