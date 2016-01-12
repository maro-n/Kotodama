﻿
using UnityEngine;


public class Sentence_PublicPhone : MonoBehaviour {

  EventState PublicPhone;
  EventChecker Check;

  void Start() {
    PublicPhone = this.gameObject.GetComponentInChildren<EventState>();
    PublicPhone._entry = TextPublicPhone;
    Check = gameObject.transform.root.gameObject.AddComponent<EventChecker>();

        
  }

  void Update() {
    if (PublicPhone._isAlreadyNovel && DialButton_Ver2.ClearFlug_PublicPhone)
      Check.Stop();
    else if (PublicPhone._isAlreadyNovel && !DialButton_Ver2.ClearFlug_PublicPhone)
      PublicPhone._isAlreadyNovel = false;

        
  }

  public string[,] TextPublicPhone = {
    { Command.start, "", "", "" },
    { Command.act, "InsertStart", "", "" },
    { Command.name, CharaName.mari, "" , ""},
    { Command.text, "「……これって……」", "", "" },

    { Command.name, CharaName.narrator,"",""},
    { Command.text, "公衆電話をつかいますか？", "", "" },
    { Command.jump, "つかってみる(YesUse)", "やっぱりやめる(NoUse)", "" },

    { Command.act, "YesUse", "", "" },
    { Command.text, "……………………", "", "" },
    { Command.end, "", "", "" },

    { Command.act,  "NoUse", "", "" },
    { Command.cashb, "false", "", ""},
    { Command.end, "", "", "" },

    
  };
}
