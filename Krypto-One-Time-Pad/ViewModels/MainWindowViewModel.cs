﻿using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Text;
using Avalonia.Logging;
using JetBrains.Annotations;
using ReactiveUI;

namespace Krypto_One_Time_Pad.ViewModels
{
	public class MainWindowViewModel : ReactiveObject
	{
		private string plainText = "Tutaj możesz wpisać tekst jawny w formie UTF-8";
		private int plainTextLenght = 0;
		private string cipherText = "Tutaj możesz wpisać szyfrogram w formie UTF-8";
		private int cipherTextLenght = 0;
		private string key  = "Tutaj możesz wpisać klucz w formie UTF-8";
		private int keyLenght = 0;

		

		public string PlainText
		{
			get => plainText;
			set
			{
				this.RaiseAndSetIfChanged(ref plainText, value);
				PlainTextLenght = plainText.Length;
			}
		}

		public int PlainTextLenght
		{
			get => plainTextLenght;
			set => this.RaiseAndSetIfChanged(ref plainTextLenght, value);
		}
		public string CipherText
		{
			get => cipherText;
			set
			{
				this.RaiseAndSetIfChanged(ref cipherText, value);
				CipherTextLenght = CipherText.Length;
			}
		}

		public int CipherTextLenght
		{
			get => cipherTextLenght;
			set => this.RaiseAndSetIfChanged(ref cipherTextLenght, value);
		}
		
		public string Key
		{
			get => key;
			set
			{
				this.RaiseAndSetIfChanged(ref key, value);
				KeyLenght = key.Length;
			}
		}

		public int KeyLenght
		{
			get => keyLenght;
			set => this.RaiseAndSetIfChanged(ref keyLenght, value);
		}
	}
}