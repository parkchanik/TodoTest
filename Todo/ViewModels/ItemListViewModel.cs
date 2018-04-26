using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;
using Xamarin.Forms.Internals;

namespace Todo
{
    public class ItemListViewModel
    {
        
        public ObservableCollection<ItemListViewModel> TodoItems { get; set; }
           
        public ItemListViewModel()
        {
            this.TodoItems = new ObservableCollection<ItemListViewModel>();
            //Just for tesing
            /*
            this.TodoItems.Add(new TodoItem
            {
                Name = "test"
            });
            this.TodoItems.Add(new TodoItem
            {
                Name = "test2"
            });
            */
            
            //System.Globalization.ko
        }

            
        public async Task UpdatePostsAsync()
        {
            var newPosts = await App.Database.GetItemsAsync();
            this.TodoItems.Clear();
            newPosts.ForEach((TodoItem) =>
            {
                /*
                ViewTest test = new ViewTest();
                test.Name = TodoItem.Name;
                test.count = TodoItem.Name.Length;
                */
                this.TodoItems.Add(new ItemListViewModel(TodoItem.Name , TodoItem.Name.Length, "test") );
                
           
            });
        }

        
        public class ViewTest
        {
            public string Name { get; set; }
            public int count { get; set; }
            public bool Done { get; set; }
        }
        


        public ItemListViewModel(string Name , int Count , string Test)
        {
            name = Name;
            count = Count;
            test = Test;
        }

        public string name { get; set; }
        public int count { get; set; }
        public string test { get; set; }

        /*
        static ItemListViewModel()
        {
            
            All = new List<ItemListViewModel>
            {
                new ItemListViewModel("test" , 1 , "11111") ,
                new ItemListViewModel("test11" , 2 , "22") ,
                new ItemListViewModel("test33" , 3 , "333")
            };
            */
            /*
            All = new List<ItemListViewModel>();

            var newPosts = await App.Database.GetItemsAsync();

            newPosts.ForEach((TodoItem) =>
            {

                All.Add(new ItemListViewModel(TodoItem.Name, 2, "tst"));

            });
            


        }

        public static IList<ItemListViewModel> All { get; set; }
        */
        
    }


}
