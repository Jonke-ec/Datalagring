   M S B A M L   `   `   `  ����N  JEntityFramework_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_WPF.ViewsEntityFramework_WPF.Views  5      /    )EntityFramework_WPF.Views.NewCustomerView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EntityFramework_WPF.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Ny Kund��6!   $��18(�60   $
��Left=�6>   $��Center=�6Y   �� 5   
   $��1��6   $��0��6"   $��20 10q�62   .+�5      �� $��Förnamn��6   �� 5      -   5         ��Name$ tbFirstName��5      $��5q�6+   $��0 3 0 10q�67   �� 5      $��Email��6   �� 5      -   5        $ tbEmail��5      $��5q�6'   $��0 3 0 10q�63   �� 5      $��Adress��6   �� 5      -   5        $ 	tbAddress��5      $��5q�6)   $��0 3 0 10q�65   �� 5      $
��Stad��6   �� 5      -   5        $ tbCity��5      $��5q�6&   $��0 3 0 10q�62   �� 5      -   5         ��Name$ btnAdd��5      $��14(�6%   $��
Lägg till��63   $	��0 5q�6G   $��20q�6j   �� 5      -   5         ��Name$ lbError��5      
���  ��$��14(�6:   $��30q�6H   $��Center=�6T   5       �� 5"   
   $��1��6   $��1��6"   $��20 10q�62   .+�5#      �� $��	Efternamn��6   �� 5$      -   5        $ 
tbLastName��5$      $��5q�6*   $��0 3 0 10q�66   �� 5%      $��Mobilnummer��6   �� 5&      -   5        $ tbPhoneNumber��5&      $��5q�6-   $��0 3 0 10q�69   �� 5'      $��Postkod��6   �� 5(      -	   5        $ tbPostalcode��5(      $��5q�6,   $��0 3 0 10q�68   �� 5)      $
��Land��6   �� 5*      -
   5        $ 	tbCountry��5*      $��5q�6)   $��0 3 0 10q�65   5+      5-      5.      