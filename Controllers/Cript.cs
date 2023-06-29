using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Cript
{
	public string Descriptografa(string dado)
	{
		string Retorno = "";
		string pKey = "12345678";
		string sKey = "87654321";
		byte[] privatekeyByte = { };
		privatekeyByte = System.Text.Encoding.UTF8.GetBytes(sKey);
		byte[] publickeybyte = { };
		publickeybyte = System.Text.Encoding.UTF8.GetBytes(pKey);
		MemoryStream ms = null;
		CryptoStream cs = null;
		byte[] inputbyteArray = new byte[dado.Replace(" ", "+").Length];
		inputbyteArray = Convert.FromBase64String(dado.Replace(" ", "+"));
		using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
		{
			ms = new MemoryStream();
			cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
			cs.Write(inputbyteArray, 0, inputbyteArray.Length);
			cs.FlushFinalBlock();
			Encoding encoding = Encoding.UTF8;
			Retorno = encoding.GetString(ms.ToArray());
		}
		return Retorno;
	}


	public string Criptografa(string dado)
	{

		string Retorno = "";
		string pKey = "12345678";
		string sKey = "87654321";
		byte[] secretkeyByte = { };
		secretkeyByte = System.Text.Encoding.UTF8.GetBytes(sKey);
		byte[] publickeybyte = { };
		publickeybyte = System.Text.Encoding.UTF8.GetBytes(pKey);
		MemoryStream ms = null;
		CryptoStream cs = null;
		byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(dado);
		using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
		{
			ms = new MemoryStream();
			cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
			cs.Write(inputbyteArray, 0, inputbyteArray.Length);
			cs.FlushFinalBlock();
			Retorno = Convert.ToBase64String(ms.ToArray());
		}
		return Retorno;
	}	
}
