   M S B A M L   `   `   `  ����R  NProductManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ProductManagementSystem.ViewsProductManagementSystem.Views  5      -    'ProductManagementSystem.Views.LoginView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:ProductManagementSystem.Views     5      
���   �.��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��2��6!   $��0��65   $��3q�6B   
�������$��50,10,50,10q�6j   ._�5      �� $��0��5      $��2��5      $��0��5      $��Product Management System��5      
�������$��Center=�5      $��Center=�5      $��30(�5       5!      �� 5#   
   $��0��6   $��1��6!   $��3q�6.   
�������$��50,10,50,10q�6V   ._�5$      �� $��0��5%      $��1��5&      $��Server Location��5'      
�������$��Center=�5)      $��Center=�5*      $��20(�5+      5,      �� 5.   
   $��0��6   $��2��6!   $��3q�6.   
�������$��50,10,50,10q�6V   ._�5/      �� $��0��50      $��2��51      $��Database Name��52      
�������$��Center=�54      $��Center=�55      $��20(�56      57      �� 59   
   $��0��6   $��3��6!   $��3q�6.   
�������$��50,10,50,10q�6V   ._�5:      �� $��0��5;      $��3��5<      $��UserName��5=      
�������$��Center=�5?      $��Center=�5@      $��20(�5A      5B      �� 5D   
   $��0��6   $��4��6!   $��3q�6.   
�������$��50,10,50,10q�6V   ._�5E      �� $��0��5F      $��4��5G      $��Password��5H      
�������$��Center=�5J      $��Center=�5K      $��20(�5L      5M      �� 5O   
   $��0��6   $��2��6!   $��5��65   $��Connect��6B   ��6T   �� *ConnectCommand+�� 5Q   
   $��1��6   $��1��6"   ��6/   �� *ServerLocation+�� 5R   
   $��1��6   $��2��6"   ��6/   �� *DBName+�� 5S   
   $��1��6   $��3��6"   ��6/   �� *
UserName+G� 5T   
   $��1��6   $��4��6&   5V      5W      