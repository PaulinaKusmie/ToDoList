using System;
using System.Collections.Generic;
using System.Text;

namespace ListToDo
{
    class ActivityViewModel
    {
        #region Fields
        private Guid id;
        private bool isSelected;
        private string header;
        private string description;
        private DateTime created;
        private DateTime endDoing;
        #endregion

        #region Properties

        public Guid Id { get; }
        public bool IsSelected { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime EndDoing { get; set; }

        #endregion

    }
}
