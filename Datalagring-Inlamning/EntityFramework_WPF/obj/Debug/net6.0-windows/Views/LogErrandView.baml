   M S B A M L   `   `   `  ����N  JEntityFramework_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_WPF.ViewsEntityFramework_WPF.Views  5      -    'EntityFramework_WPF.Views.LogErrandView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EntityFramework_WPF.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $
��0.5* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Lägg till ärende��6!   $��18(�69   $
��Left=�6G   $��Center=�6b   �� 5   
   $��1��6   $��0��6"   $��20 10q�62   .+�5      �� $��Kund ID��6   $��SemiBold"�6&   �� 5      -   5         ��Name$ tbCustomerId��5      $��5q�6,   $��0 3 0 20q�68   �� 5      $��Välj en rubrik:��6   $��0 0 0 20q�6.   $��SemiBold"�6A   	� 5      -   5         	�Name$ rbComplaint��5      $��Reklamation��6/   $��0 0 0 20q�6E   6X   	� 5      -   5        $ 
rbOrdering��5      $��Beställning��6.   $��0 0 0 20q�6D   6W   	� 5      -   5        $ 
rbDelivery��5      $��Leverans��6.   $��0 0 0 20q�6A   6T   	� 5      -   5        $ rbChangeReturn��5      $��Byte/ Retur��62   $��0 0 0 20q�6H   6[   	� 5      -   5        $ rbOther��5      $��Övrigt��6+   $��0 0 0 20q�6<   6O   5      �� 5    
   $��1��6   $��1��6"   $��20 10q�62   .+�5!      �� $��Beskriv ärendet:��6   $��SemiBold"�6/   �� 5"      -   5        $ tbErrandDescription��5"      $��5q�63   $��0 3 0 0q�6?   $	��150��6P   �� 5#      $��
(max: 200)��6   $��Light"�6)   $��10(�6<   $��Right=�6J   �� 5$      $��Status:��6   $��SemiBold"�6&   �� 5%       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��	0 10 0 10q�6O   .+�5&      	� -   5        $ rbNotStarted��5&      $��Ej påbörjad��64   $��0 0 80 0q�6J   6]   	� 5'      -	   5        $ 	rbTreated��5'      $��	Behandlas��61   $��0 0 80 0q�6E   6X   	� 5(      -
   5        $ rbCompleted��5(      $��Avslutad��63   $��0q�6F   6R   5)      �� 5*      -   5         ��Name$ btnAdd��5*      $��14(�6%   $��
Lägg till��63   $	��0 5q�6G   $��
40 60 40 0q�6j   �� 5+      -   5         ��Name$ lbError��5+      
���  ��$��14(�6:   $��30q�6H   $��Center=�6T   5,      5.      5/      