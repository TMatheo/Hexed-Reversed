using System;
using System.IO;
using System.Security.Cryptography;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Hexed.HexedServer
{
	// Token: 0x02000004 RID: 4
	internal class DataEncryptBase
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002860 File Offset: 0x00000A60
		public static string DecryptData(object combinedString, object privateKey)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_33;
				case 2:
				{
					RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
					num2 = 1;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a1b182db64e046d6b8d2209f5172a3a2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 3:
				{
					string[] array = qsuQo78KIcENh5rnMRL.bHC8kRmMET(combinedString, '|', StringSplitOptions.None, qsuQo78KIcENh5rnMRL.myt8gyUbOi);
					string text = array[0];
					string text2 = array[1];
					object obj = array[2];
					byte[] array2 = umZlS685wVdN3IX1GXn.bHC8kRmMET(text, umZlS685wVdN3IX1GXn.n1W8Z5ADUD);
					byte[] array3 = DataEncryptBase.pb5LrT586nJ6qgeWbja(text2, umZlS685wVdN3IX1GXn.n1W8Z5ADUD);
					byte[] array4 = DataEncryptBase.pb5LrT586nJ6qgeWbja(obj, umZlS685wVdN3IX1GXn.n1W8Z5ADUD);
					num2 = 1;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_d3bd672fa62045a1b03efd2663c98911 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				}
				break;
			}
			string result;
			return result;
			IL_33:
			try
			{
				RSACryptoServiceProvider rsacryptoServiceProvider;
				DataEncryptBase.QTZDft5kYCvP3r7nWLG(rsacryptoServiceProvider, privateKey, FlM8d38FPl96AMamdMr.lgR8lgRbl5);
				int num3 = 4;
				for (;;)
				{
					switch (num3)
					{
					case 1:
					{
						byte[] array2;
						byte[] array6;
						byte[] array7;
						byte[] array5 = DataEncryptBase.kh00HI5H3VdwCkKPX0F(array2, array6, array7);
						num3 = 3;
						continue;
					}
					case 2:
					{
						byte[] array4;
						byte[] array7 = DataEncryptBase.dCFjA35QIyojlyecmSs(rsacryptoServiceProvider, array4, false, vmgG2u82Skl9dKrPs4m.qYE8na7nVX);
						num3 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4672c511600c49b1b4a7904620d7df97 == 0)
						{
							num3 = 0;
							continue;
						}
						continue;
					}
					case 3:
					{
						byte[] array5;
						result = fXW6gJ8PIStty01cgNi.bHC8kRmMET(DataEncryptBase.Vg9Dd55Kf2eg3yWKxaf(gED3AQ89wWdRCnniOSF.mf58cvaWAg), array5, fXW6gJ8PIStty01cgNi.tcj8Gcru4r);
						num3 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_adb9a569109848d3a85e7bb46ab187f4 != 0)
						{
							num3 = 0;
							continue;
						}
						continue;
					}
					case 4:
					{
						byte[] array3;
						byte[] array6 = DataEncryptBase.dCFjA35QIyojlyecmSs(rsacryptoServiceProvider, array3, false, vmgG2u82Skl9dKrPs4m.qYE8na7nVX);
						num3 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a1b182db64e046d6b8d2209f5172a3a2 != 0)
						{
							num3 = 2;
							continue;
						}
						continue;
					}
					}
					break;
				}
			}
			finally
			{
				RSACryptoServiceProvider rsacryptoServiceProvider;
				if (rsacryptoServiceProvider != null)
				{
					int num4 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_d2b07095c1054ace83ccc535c86a470e == 0)
					{
						num4 = 0;
					}
					for (;;)
					{
						switch (num4)
						{
						default:
							DataEncryptBase.kw5RVK5gZG7biEHn87T(rsacryptoServiceProvider, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
							num4 = 0;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_60e6e0b79a02463f9ad45f0724e6091f == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							goto IL_187;
						}
					}
				}
				IL_187:;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002AB0 File Offset: 0x00000CB0
		private static byte[] DecryptWithAes(object data, object key, object iv)
		{
			int num = 2;
			int num2 = num;
			byte[] result;
			for (;;)
			{
				Aes aes;
				switch (num2)
				{
				case 1:
					try
					{
						DataEncryptBase.qsfNo15Za7Eyk2G3wHC(aes, key, x6xT9G8ajVwxF7InFtb.POn8mVcspS);
						int num3 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_281c127287bd473e88eb06f4b1d2ac06 == 0)
						{
							num3 = 1;
						}
						MemoryStream memoryStream;
						for (;;)
						{
							switch (num3)
							{
							case 1:
								R1kcBh8RLnhhSrlvYHJ.bHC8kRmMET(aes, iv, R1kcBh8RLnhhSrlvYHJ.Nao8TYtXcp);
								num3 = 0;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_cd7ba99b21134a51bee3ca0da26a5e18 == 0)
								{
									num3 = 0;
									continue;
								}
								continue;
							case 2:
								goto IL_B3;
							}
							memoryStream = new MemoryStream();
							num3 = 2;
						}
						IL_B3:
						try
						{
							CryptoStream cryptoStream = new CryptoStream(memoryStream, ui6wJN8toaItCMPfEkv.bHC8kRmMET(aes, ui6wJN8toaItCMPfEkv.r978C4mky0), CryptoStreamMode.Write);
							int num4 = 0;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_29f62ca47fe84304adabcf8e9ae652be == 0)
							{
								num4 = 0;
							}
							for (;;)
							{
								switch (num4)
								{
								default:
									try
									{
										DataEncryptBase.HTr4Ir5FojwAhQoVqqU(cryptoStream, data, 0, data.Length, N5ujaE8h3nJa9LxhWOf.kvH8ONXMKq);
										int num5 = 0;
										if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4672c511600c49b1b4a7904620d7df97 != 0)
										{
											num5 = 1;
										}
										for (;;)
										{
											switch (num5)
											{
											case 1:
												DataEncryptBase.zRjOSD5lgBjcSGbxtau(cryptoStream, dICFnt8pGo4vkFkDj1K.nbY8qjTAH5);
												num5 = 0;
												if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_3a95647fc8d447d1a232bbe044e11cf6 == 0)
												{
													num5 = 0;
													continue;
												}
												continue;
											}
											break;
										}
									}
									finally
									{
										if (cryptoStream != null)
										{
											int num6 = 0;
											if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_80ae2bbf08304c42b54383f3bd026882 != 0)
											{
												num6 = 0;
											}
											for (;;)
											{
												switch (num6)
												{
												default:
													DataEncryptBase.kw5RVK5gZG7biEHn87T(cryptoStream, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
													num6 = 1;
													if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_e6f884cc5c5a4d5a9126f9f13e859e11 != 0)
													{
														num6 = 1;
													}
													break;
												case 1:
													goto IL_1E1;
												}
											}
										}
										IL_1E1:;
									}
									break;
								case 1:
									break;
								case 2:
									goto IL_219;
								}
								result = DataEncryptBase.PSbHC252n3erFGudaiA(memoryStream, V7pmFB8VwE61ZGMQtjm.r2P8DCyt2u);
								num4 = 2;
							}
							IL_219:
							break;
						}
						finally
						{
							if (memoryStream != null)
							{
								goto IL_271;
							}
							int num7 = 1;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_424358abb6d34df6af0bdefbf9b91057 == 0)
							{
								num7 = 0;
							}
							IL_248:
							switch (num7)
							{
							case 2:
								IL_271:
								rB3NI18uG4FKi3JV6A0.bHC8kRmMET(memoryStream, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
								num7 = 0;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a6e501c0a84745f2be250cd2b7bdccea == 0)
								{
									num7 = 0;
									goto IL_248;
								}
								goto IL_248;
							}
						}
					}
					finally
					{
						if (aes != null)
						{
							goto IL_2EC;
						}
						int num8 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_424358abb6d34df6af0bdefbf9b91057 == 0)
						{
							num8 = 0;
						}
						IL_2C7:
						switch (num8)
						{
						case 2:
							IL_2EC:
							rB3NI18uG4FKi3JV6A0.bHC8kRmMET(aes, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
							num8 = 1;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_6c07fbf92d70437ea31a7f0bd2319090 == 0)
							{
								num8 = 1;
								goto IL_2C7;
							}
							goto IL_2C7;
						}
					}
					goto IL_337;
				case 2:
					goto IL_337;
				}
				break;
				IL_337:
				aes = DataEncryptBase.NrtvCo55jOjFHBvnuNt(tVHAfy8SlYUEQPxXFhh.nNq8YQy6er);
				num2 = 1;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_ca6c0311d7d54363be25ff6f814ff3d6 != 0)
				{
					num2 = 1;
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002E70 File Offset: 0x00001070
		public static string EncryptData(object dataToEncrypt, object publicKey)
		{
			int num = 2;
			int num2 = num;
			string result;
			for (;;)
			{
				Aes aes;
				switch (num2)
				{
				default:
					return result;
				case 1:
					try
					{
						byte[] array = DataEncryptBase.cppYoj5PK1rTFuqrcoW(DataEncryptBase.UjY4Nt5n1ZeTy0EDd4g(DataEncryptBase.Vg9Dd55Kf2eg3yWKxaf(gED3AQ89wWdRCnniOSF.mf58cvaWAg), dataToEncrypt, mrkkrg80urn55ADtOuI.E0J8sDclI1), DataEncryptBase.rbRReD591DoKn0RC3JZ(aes, qKqvyv8UU2yy0lhvbFv.ful8BRs38j), DataEncryptBase.AshTSY5ccIHWES7eaKb(aes, TvVc0J8MLI5t7e0pDMA.SDc8L6TtZq));
						int num3 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4c15694ce4de4de99550ff9a16745dfb == 0)
						{
							num3 = 0;
						}
						RSACryptoServiceProvider rsacryptoServiceProvider;
						for (;;)
						{
							switch (num3)
							{
							default:
								rsacryptoServiceProvider = new RSACryptoServiceProvider();
								num3 = 1;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_cddfc40cd36944feba63584f794d66e0 == 0)
								{
									num3 = 1;
								}
								break;
							case 1:
								goto IL_C2;
							}
						}
						IL_C2:
						try
						{
							FlM8d38FPl96AMamdMr.bHC8kRmMET(rsacryptoServiceProvider, publicKey, FlM8d38FPl96AMamdMr.lgR8lgRbl5);
							int num4 = 3;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_bb6e445865874c27b93bef92a841963a == 0)
							{
								num4 = 0;
							}
							for (;;)
							{
								byte[] array2;
								byte[] array3;
								switch (num4)
								{
								case 1:
									goto IL_21B;
								case 2:
									array2 = A8wjga8IXxQFRSTam7T.bHC8kRmMET(rsacryptoServiceProvider, DataEncryptBase.AshTSY5ccIHWES7eaKb(aes, TvVc0J8MLI5t7e0pDMA.SDc8L6TtZq), false, A8wjga8IXxQFRSTam7T.tGU84ZPnp5);
									num4 = 0;
									if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_8d4dbb3930ae4693a73f1a224ce8dc43 == 0)
									{
										num4 = 0;
										continue;
									}
									continue;
								case 3:
									array3 = DataEncryptBase.wYI4OA5GgEp4AJCqaAS(rsacryptoServiceProvider, DataEncryptBase.rbRReD591DoKn0RC3JZ(aes, qKqvyv8UU2yy0lhvbFv.ful8BRs38j), false, A8wjga8IXxQFRSTam7T.tGU84ZPnp5);
									num4 = 2;
									if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_8d4dbb3930ae4693a73f1a224ce8dc43 != 0)
									{
										num4 = 2;
										continue;
									}
									continue;
								}
								result = DataEncryptBase.lxLAe35SrJRxT9OdxyO(new string[]
								{
									F7jp8b8yCs2GQoL7RVL.bHC8kRmMET(array, F7jp8b8yCs2GQoL7RVL.CTO8JCxmj0),
									DataEncryptBase.pfXYay5uHodPyTROjsN(-742354945 ^ -723438023 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_91ecb92b03d4435895297ab3dd5d0d35),
									DataEncryptBase.MvdQJE5x14fvsp6fWwS(array3, F7jp8b8yCs2GQoL7RVL.CTO8JCxmj0),
									DataEncryptBase.pfXYay5uHodPyTROjsN(1281814382 ^ 130516642 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a68de468d55d4f2692453ef066e511c3),
									DataEncryptBase.MvdQJE5x14fvsp6fWwS(array2, F7jp8b8yCs2GQoL7RVL.CTO8JCxmj0)
								}, XnriDm8fDYJsZ8Dx2nR.Wux8vgPRVJ);
								num4 = 1;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_6b43bb7ee2e8409f91d7937cc0ad4c1e == 0)
								{
									num4 = 0;
								}
							}
							IL_21B:
							return result;
						}
						finally
						{
							if (rsacryptoServiceProvider != null)
							{
								goto IL_284;
							}
							int num5 = 1;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_b7810d34983c4b51b97ba8e20f65198c == 0)
							{
								num5 = 1;
							}
							IL_24A:
							switch (num5)
							{
							case 0:
								goto IL_284;
							case 1:
								break;
							case 2:
								break;
							default:
								goto IL_284;
							}
							break;
							IL_284:
							rB3NI18uG4FKi3JV6A0.bHC8kRmMET(rsacryptoServiceProvider, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
							num5 = 2;
							goto IL_24A;
						}
					}
					finally
					{
						if (aes != null)
						{
							goto IL_2EA;
						}
						int num6 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a68de468d55d4f2692453ef066e511c3 == 0)
						{
							num6 = 0;
						}
						IL_2C5:
						switch (num6)
						{
						case 2:
							IL_2EA:
							DataEncryptBase.kw5RVK5gZG7biEHn87T(aes, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
							num6 = 0;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_d131f51f19cd4f64ab4ade58506e9eaf == 0)
							{
								num6 = 0;
								goto IL_2C5;
							}
							goto IL_2C5;
						}
					}
					break;
				case 2:
					break;
				}
				aes = DataEncryptBase.NrtvCo55jOjFHBvnuNt(tVHAfy8SlYUEQPxXFhh.nNq8YQy6er);
				num2 = 1;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_b5429e1f34e34ad58401b9f6b18e0718 == 0)
				{
					num2 = 1;
				}
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003210 File Offset: 0x00001410
		private static byte[] EncryptWithAes(object data, object key, object iv)
		{
			int num = 1;
			int num2 = num;
			Aes aes;
			byte[] result;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					aes = DataEncryptBase.NrtvCo55jOjFHBvnuNt(tVHAfy8SlYUEQPxXFhh.nNq8YQy6er);
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_fe45161609c04eb1bb3808d3ebcf88dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return result;
				}
				break;
			}
			try
			{
				DataEncryptBase.qsfNo15Za7Eyk2G3wHC(aes, key, x6xT9G8ajVwxF7InFtb.POn8mVcspS);
				int num3 = 1;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_2b81ec8af5e04f369f0d06aea74493ed == 0)
				{
					num3 = 1;
				}
				MemoryStream memoryStream;
				for (;;)
				{
					switch (num3)
					{
					case 1:
					{
						DataEncryptBase.kGtcBx5YaBbVZHjevZT(aes, iv, R1kcBh8RLnhhSrlvYHJ.Nao8TYtXcp);
						int num4 = 2;
						num3 = num4;
						continue;
					}
					case 2:
						memoryStream = new MemoryStream();
						num3 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_7d3f6a88267b4d238540be494dd7d668 == 0)
						{
							num3 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				try
				{
					CryptoStream cryptoStream = new CryptoStream(memoryStream, DataEncryptBase.LvRI655aVFmyS9s0FAe(aes, rsoo0E8AxnxJUJ53rh7.paj8XNLhMs), CryptoStreamMode.Write);
					int num5 = 1;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_bd6aead8603847dd81ce1b01831ceada == 0)
					{
						num5 = 0;
					}
					for (;;)
					{
						switch (num5)
						{
						case 1:
							try
							{
								DataEncryptBase.HTr4Ir5FojwAhQoVqqU(cryptoStream, data, 0, data.Length, N5ujaE8h3nJa9LxhWOf.kvH8ONXMKq);
								int num6 = 0;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_7474901a2006436a9b6dac99970e4c99 == 0)
								{
									num6 = 0;
								}
								for (;;)
								{
									switch (num6)
									{
									default:
										DataEncryptBase.zRjOSD5lgBjcSGbxtau(cryptoStream, dICFnt8pGo4vkFkDj1K.nbY8qjTAH5);
										num6 = 1;
										if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_7474901a2006436a9b6dac99970e4c99 == 0)
										{
											num6 = 1;
										}
										break;
									case 1:
										goto IL_1A4;
									}
								}
								IL_1A4:;
							}
							finally
							{
								if (cryptoStream != null)
								{
									int num7 = 1;
									if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_b5429e1f34e34ad58401b9f6b18e0718 == 0)
									{
										num7 = 1;
									}
									for (;;)
									{
										switch (num7)
										{
										case 1:
											DataEncryptBase.kw5RVK5gZG7biEHn87T(cryptoStream, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
											num7 = 0;
											if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_19ee2fff40164b58a7e95a8fcf0cd6fb == 0)
											{
												num7 = 0;
												continue;
											}
											continue;
										}
										break;
									}
								}
							}
							break;
						case 2:
							goto IL_25D;
						}
						result = V7pmFB8VwE61ZGMQtjm.bHC8kRmMET(memoryStream, V7pmFB8VwE61ZGMQtjm.r2P8DCyt2u);
						num5 = 2;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_0988bb91a7564243b679db7669ea9a29 == 0)
						{
							num5 = 2;
						}
					}
					IL_25D:;
				}
				finally
				{
					if (memoryStream != null)
					{
						int num8 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_f57147600bec46dcbedf8e1d19383d3c != 0)
						{
							num8 = 0;
						}
						for (;;)
						{
							switch (num8)
							{
							case 1:
								DataEncryptBase.kw5RVK5gZG7biEHn87T(memoryStream, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
								num8 = 0;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_6b43bb7ee2e8409f91d7937cc0ad4c1e == 0)
								{
									num8 = 0;
									continue;
								}
								continue;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (aes != null)
				{
					int num9 = 1;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a74f7fabfa7e45b9b0eb2c2e973363fd == 0)
					{
						num9 = 1;
					}
					for (;;)
					{
						switch (num9)
						{
						case 1:
							DataEncryptBase.kw5RVK5gZG7biEHn87T(aes, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
							num9 = 0;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_29f62ca47fe84304adabcf8e9ae652be != 0)
							{
								num9 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000035BC File Offset: 0x000017BC
		public DataEncryptBase()
		{
			DataEncryptBase.pXrr1q5mJWjkqAMYcsK();
			DataEncryptBase.na6KQI5RA64uP9hCLO4();
			base..ctor();
			int num = 0;
			if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_281c127287bd473e88eb06f4b1d2ac06 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003620 File Offset: 0x00001820
		// Note: this type is marked as 'beforefieldinit'.
		static DataEncryptBase()
		{
			DataEncryptBase.ampDtS5TSTcowZUJn3Y();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003630 File Offset: 0x00001830
		internal static object pb5LrT586nJ6qgeWbja(object A_0, object A_1)
		{
			return umZlS685wVdN3IX1GXn.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003648 File Offset: 0x00001848
		internal static void QTZDft5kYCvP3r7nWLG(object A_0, object A_1, object A_2)
		{
			FlM8d38FPl96AMamdMr.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003664 File Offset: 0x00001864
		internal static object dCFjA35QIyojlyecmSs(object A_0, object A_1, bool A_2, object A_3)
		{
			return vmgG2u82Skl9dKrPs4m.bHC8kRmMET(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003684 File Offset: 0x00001884
		internal static object kh00HI5H3VdwCkKPX0F(object A_0, object A_1, object A_2)
		{
			return DataEncryptBase.DecryptWithAes(A_0, A_1, A_2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000036A0 File Offset: 0x000018A0
		internal static object Vg9Dd55Kf2eg3yWKxaf(object A_0)
		{
			return gED3AQ89wWdRCnniOSF.bHC8kRmMET(A_0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000036B4 File Offset: 0x000018B4
		internal static void kw5RVK5gZG7biEHn87T(object A_0, object A_1)
		{
			rB3NI18uG4FKi3JV6A0.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000036CC File Offset: 0x000018CC
		internal static bool u5xe3JgzYYmTn3vbrCv()
		{
			return DataEncryptBase.mJnqAfgrh1SSr9LPdbE == null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000036E0 File Offset: 0x000018E0
		internal static DataEncryptBase NPtKBe577wDD7J7qE6c()
		{
			return DataEncryptBase.mJnqAfgrh1SSr9LPdbE;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000036F0 File Offset: 0x000018F0
		internal static object NrtvCo55jOjFHBvnuNt(object A_0)
		{
			return tVHAfy8SlYUEQPxXFhh.bHC8kRmMET(A_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003704 File Offset: 0x00001904
		internal static void qsfNo15Za7Eyk2G3wHC(object A_0, object A_1, object A_2)
		{
			x6xT9G8ajVwxF7InFtb.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003720 File Offset: 0x00001920
		internal static void HTr4Ir5FojwAhQoVqqU(object A_0, object A_1, int A_2, int A_3, object A_4)
		{
			N5ujaE8h3nJa9LxhWOf.bHC8kRmMET(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003744 File Offset: 0x00001944
		internal static void zRjOSD5lgBjcSGbxtau(object A_0, object A_1)
		{
			dICFnt8pGo4vkFkDj1K.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000375C File Offset: 0x0000195C
		internal static object PSbHC252n3erFGudaiA(object A_0, object A_1)
		{
			return V7pmFB8VwE61ZGMQtjm.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003774 File Offset: 0x00001974
		internal static object UjY4Nt5n1ZeTy0EDd4g(object A_0, object A_1, object A_2)
		{
			return mrkkrg80urn55ADtOuI.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003790 File Offset: 0x00001990
		internal static object rbRReD591DoKn0RC3JZ(object A_0, object A_1)
		{
			return qKqvyv8UU2yy0lhvbFv.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000037A8 File Offset: 0x000019A8
		internal static object AshTSY5ccIHWES7eaKb(object A_0, object A_1)
		{
			return TvVc0J8MLI5t7e0pDMA.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000037C0 File Offset: 0x000019C0
		internal static object cppYoj5PK1rTFuqrcoW(object A_0, object A_1, object A_2)
		{
			return DataEncryptBase.EncryptWithAes(A_0, A_1, A_2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000037DC File Offset: 0x000019DC
		internal static object wYI4OA5GgEp4AJCqaAS(object A_0, object A_1, bool A_2, object A_3)
		{
			return A8wjga8IXxQFRSTam7T.bHC8kRmMET(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000037FC File Offset: 0x000019FC
		internal static object pfXYay5uHodPyTROjsN(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003810 File Offset: 0x00001A10
		internal static object MvdQJE5x14fvsp6fWwS(object A_0, object A_1)
		{
			return F7jp8b8yCs2GQoL7RVL.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003828 File Offset: 0x00001A28
		internal static object lxLAe35SrJRxT9OdxyO(object A_0, object A_1)
		{
			return XnriDm8fDYJsZ8Dx2nR.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003840 File Offset: 0x00001A40
		internal static void kGtcBx5YaBbVZHjevZT(object A_0, object A_1, object A_2)
		{
			R1kcBh8RLnhhSrlvYHJ.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000385C File Offset: 0x00001A5C
		internal static object LvRI655aVFmyS9s0FAe(object A_0, object A_1)
		{
			return rsoo0E8AxnxJUJ53rh7.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003874 File Offset: 0x00001A74
		internal static void pXrr1q5mJWjkqAMYcsK()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003884 File Offset: 0x00001A84
		internal static void na6KQI5RA64uP9hCLO4()
		{
			nHwRpygmi6xxZAssJn.JvcaFtwnsV();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003894 File Offset: 0x00001A94
		internal static void ampDtS5TSTcowZUJn3Y()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400000B RID: 11
		internal static object mJnqAfgrh1SSr9LPdbE;
	}
}
