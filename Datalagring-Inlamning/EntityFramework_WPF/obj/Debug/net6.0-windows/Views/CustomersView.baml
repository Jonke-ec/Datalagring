   M S B A M L   `   `   `  ����N  JEntityFramework_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_WPF.ViewsEntityFramework_WPF.Views  5      -    'EntityFramework_WPF.Views.CustomersView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EntityFramework_WPF.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��	Kundlista��6,   $��18(�6=   $
��Left=�6K   $��7q�6f   $��Center=�6q   5      � 5      $��7q�6    5      �� 5      $
��0.5* �6'   �� 5      $
��1.5* �6'   �� 5      $��2* �6'   �� 5      $
��1.5* �6'   .+�5!      �� $��0��6   $��#��6,   �� 5"      $��1��6   $
��Namn��6,   �� 5#      $��2��6   $��Email��6,   �� 5$      $��3��6   $��Mobilnummer��6,   5%      5&      �� 5)   
   -   5         ��Name$ lvCustomers��5)       � DataContext$ Wpf.Models.Customer��6(   $��1��6J   
������ $��Stretch=�6p   $��Stretch=�6�   ��5*      �� 5+      .R�5,      �  5-      �� 5.      $
��0.5* �6/   �� 5/      $
��1.5* �6/   �� 50      $��2* �6/   �� 51      $
��1.5* �6/   .+�54      �� $��0��6$   ��64   �� *Id+�� 55      $��1��6$   ��64   �� *
FullName+�� 56      $��2��6$   ��64   �� *Email+�� 57      $��3��6$   ��64   �� *PhoneNumber+58      59      5;      5<      5=      