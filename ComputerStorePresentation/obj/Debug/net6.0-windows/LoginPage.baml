   M S B A M L   `   `   `  ????T  PComputerStorePresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ComputerStorePresentationComputerStorePresentation  5      )    #ComputerStorePresentation.LoginPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ComputerStorePresentation     5        N? Title$  	LoginPage??5	       N? 
Background
 ?????$	??450??60   $	??800??6=   .??5      ? $??10,0,0,0q?6    ? ColumnDefinitions 5   
   ?? 5      $	??77* ?6   ?? 5      $
??523* ?6   .+?5   
   ?? -   5         ??Name$ LoginTextbox??5      $
??Left=?6(   $??203,158,0,0q?6C    ?? TextWrapping$
 Wrap=?6X   $	??Top=?6l   $	??172??6?   $??20??6?   $??1??6?   ?? 5   
   -   5         ??Name$ LoginButton??5      $??
Войти??6@   $
??Left=?6P   $??229,217,0,0q?6k   $	??Top=?6?   $	??120??6?   $??1??6?   ?? 5   
   -   5        $ RegistrationButton??5      $*??$Зарегистрироваться??6N   $
??Left=?6k   $??219,305,0,0q?6?   $	??Top=?6?   $	??140??6?   $??1??6?   ?? 5   
   $
??Left=?6   $??250,284,0,0q?6/   $
??Wrap=?6D   $??Нет аккаунта???6X   $	??Top=?6n   $??78??6?   $??1??6?   G? 5   
   -   5         G?Name$ PassTextbox??5      $??1??6+   $
??Left=?6;   $??203,183,0,0q?6V   $	??Top=?6k   $	??172??6?   $??20??6?   ?? 5   
   $??1??6   $
??Left=?6$   $??219,134,0,0q?6?   $
??Wrap=?6T   $0??*Введите логин и пароль:??6h   $	??Top=?6?   $	??150??6?   $??24??6?   ?? 5   
   -   5         ??Name$ UncorrectBlock??5      $??1??6,   $
??Left=?6<   $??203,252,0,0q?6W   $
??Wrap=?6l   $?? ??6?   $	??Top=?6?   $	??219??6?   5      5      