using CatAteBug.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAteBug.ViewModels
{
    internal partial class BugViewModel : ViewModelBase
    {

        public BugViewModel() { }

        public BugViewModel(Bug bug)
        {
            IsActive = bug.IsActive;
            Name = bug.Name;
            Description = bug.Description;
            AddedDate = bug.AddedDate;
            ResolvedDate = bug.ResolvedDate;
        }

        [ObservableProperty]
        private bool _IsActive;

        [ObservableProperty]
        private string _Name;

        [ObservableProperty]
        private string _Description;

        [ObservableProperty]
        private DateOnly _AddedDate;

        [ObservableProperty]
        private DateOnly _ResolvedDate;

        public Bug GetBug()
        {
            return new Bug() {
            IsActive = this.IsActive,
            Name = this.Name,
            Description = this.Description,
            AddedDate = this.AddedDate,
            ResolvedDate = this.ResolvedDate
        };
        }

    }
}
