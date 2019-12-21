﻿using UniRx;
using UnityEngine;

namespace Domain.Model
{
   public class UserModel
   {
      public readonly int Id;
      public StringReactiveProperty Name = new StringReactiveProperty();
      public BoolReactiveProperty IsPaid = new BoolReactiveProperty();

      public UserModel(int id, string name, bool isPaid)
      {
          Id = id;
          Name.Value = name;
          IsPaid.Value = isPaid;

          IsPaid.SkipLatestValueOnSubscribe().Subscribe(val => Debug.Log(val));
      }
   }
}