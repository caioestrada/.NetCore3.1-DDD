using System.Collections.Generic;

namespace C.Estudo.DDD.Application.ViewModels
{
    public class ReturnViewModel
    {
        public bool Valid { get; set; }
        public bool Invalid { get; set; }
        public List<string> Notifications { get; set; }
    }
}
