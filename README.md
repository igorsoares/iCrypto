# iCrypto
 Software realizado com propósito de garantir a confidencialidade dos dados através da criptografia assimétrica/simétrica e esteganografia.
 
# Menu principal
![Presentation-01](https://user-images.githubusercontent.com/64047018/90682403-495cfc80-e23b-11ea-9b33-cfae0ec021f8.gif)

O menu principal conta com os seguintes sub-menus:

1. Criptografia  
  1.1. AES  
  1.2. RSA 
  1.3. Esteganografia  
  1.4. Cifra de césar  
  1.5. Código Morse  
2. Opções   
  2.1. Histórico
3. Sair
4. Tema   
  4.1.  Tema escuro   
  4.2.  Tema claro   
## 
 
# Confidencialidade
 iCrypto possui as seguintes funcionalidades para garantir a confidencialidade dos dados:
 
Cifra|Textos | Arquivos
---|---|---|
AES| ✅ | ✅ 
RSA|✅ |❌
César | ✅ | ❌
Morse | ✅ | ❌

As saídas cifradas podem ser enviadas por e-mail, cadastrado pelo usuário ou por opções padrões do iCrypto.

## AES

![AES-mainLogin](https://user-images.githubusercontent.com/64047018/90682198-ff741680-e23a-11ea-87b1-97c19d95f6e7.PNG)

A cifragem AES no iCrypto possui dois tamanhos de chaves: **128** e **256** bits.

Essa senha será *hasheada* e usada pelo algorítmo do AES. 

Por padrão, o iCrypto utiliza apenas o *padding*(preenchimento) **PKCS** e vetor de inicialização padrão.

![AES-EncryptDecrypt](https://user-images.githubusercontent.com/64047018/90684646-eec59f80-e23e-11ea-928c-706f5d70dabc.gif)

![Capturar](https://user-images.githubusercontent.com/64047018/90684785-25031f00-e23f-11ea-8a41-1fedc5ff46ae.PNG)

## Enviar saída por e-mail (Texto + Arquivos)

![icryptoMAILAES](https://user-images.githubusercontent.com/64047018/90685030-89be7980-e23f-11ea-8346-27c418445487.PNG)

> PS: Arquivos com extensão .exe e arquivos maiores que 25MB não serão enviados.


