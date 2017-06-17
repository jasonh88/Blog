using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.ViewModels
{
    public class ItemViewModel<T>
    {
        public T Item { get; set; }

        public static implicit operator ItemViewModel<T>(ItemViewModel<int?> v)
        {
            throw new NotImplementedException();
        }
    }
}