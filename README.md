# 自定义web服务器

## 作用
用于演示通过url访问自定义web服务器，从而实现在本地自动打开某个应用程序。

## 如何配置
* 找到MyWebServer.Core\bin\Debug\App.config中AppSettings下key为ClientLocation的项，修改其value可以设置应用程序路径
* 找到MyWebServer.Core\bin\Debug\App.config中AppSettings下key为WebServerIP的项，修改其value可以设置自己Web服务器的ip，理论上必须设置本机ip
* 找到MyWebServer.Core\bin\Debug\App.config中AppSettings下key为WebServerPort的项，修改其value可以设置自己Web服务器想要监听的端口号，请不要和任意已被占用端口号重合。

## 如何启动自定义web服务器
双击MyWebServer.Core\bin\Debug\MyWebServer.Core.exe

## 如何自动打开目标应用
启动定义web服务器后，在游览器中访问http://{WebServerIP}:{WebServerPort}，即可自动打开应用程序。