﻿using CommonUtils;
using SafeMessages.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(DataModel))]

namespace SafeMessages.Models {
  public class DataModel : ObservableObject {
    public ObservableRangeCollection<UserId> Accounts { get; set; }
    public ObservableRangeCollection<Message> Messages { get; set; }

    public DataModel() {
      Accounts = new ObservableRangeCollection<UserId>();
      Messages = new ObservableRangeCollection<Message>();
    }

    public void ClearMessages() {
      Messages.Clear();
    }
  }
}
