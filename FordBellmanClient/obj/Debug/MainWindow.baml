   M S B A M L   `   `   `  ����L  HFordBellmanClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FordBellmanClientFordBellmanClient  5   	   [2clr-namespace:FordBellmanClient.ServiceFordBellman$FordBellmanClient.ServiceFordBellman  5   	   "    FordBellmanClient.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FordBellmanClient     5   	   QServiceFordBellman2clr-namespace:FordBellmanClient.ServiceFordBellman     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � $��	0,0,0,-49q�6   $	��483��6   
�������.+�5   
   �� $2��,Алгоритм Форда-Беллмана��6   $��Center=�62   $��35��6O   $��0,10,0,0q�6[   $	��Top=�6m   $	��212��6�   $��16(�6�   �� 5   
   $Q��K1. Введите количество вершин вашего графа��6   $
��Left=�6D   $��35��6_   $��	27,48,0,0q�6k   $	��Top=�6~   $	��265��6�   �� 5   
   -   5         ��Name$ TextBox_verticesCount��5      $
��Left=�61   $��23��6L   $��
297,50,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $��6��6�   $	��Top=�6�   $	��103��6�   ���	#FFC4EBFB6�   �� 5   
   $O��I2. Введите количество ребер вашего графа��6   $
��Left=�6C   $��31��6^   $��
27,107,0,0q�6j   $	��Top=�6~   $	��265��6�   �� 5   
   -   5        $ TextBox_EdgesCount��5      $
��Left=�6.   $��23��6I   $��297,111,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��103��6�   ���	#FFC4EBFB$��6��6�   �� 5   
   $s��m4. Введите ниже список ребер в формате "вершина1 вершина2 вес"��6   $
��Left=�6c   $��27��6~   $��
27,199,0,0q�6�   $	��Top=�6�   $	��390��6�   �� 5   
   -   5         ��Name$ 
Button_run��5      $)��#Запустить алгоритм��6%   $
��Left=�6B   $��38��6]   $��
27,426,0,0q�6i   $	��Top=�6}   $	��390��6�   ���	#FFC4EBFB6�   �� 5   
   -   5         ��Name$ Panel_result��5      $
��Left=�6+   $	��355��6F   $��
445,50,0,0q�6S   $	��Top=�6g   $	��323��6   {�.  .+�5      �� $+��%Результат алгоритма��6   $��34��62   $	��128��6>   �� 5      -   5         ��Name$ TextBlock_result��5      $	��307��62   $
��Wrap=�6?   $	��281��6S   ���	#FFC4EBFB6_   5      �� 5   
   $L��F3. Введите из какой вершины искать пути��6   $
��Left=�6B   $��25��6]   $��
27,152,0,0q�6i   $	��Top=�6}   $	��255��6�   �� 5   
   -   5        $ TextBox_source��5      $
��Left=�6*   $��25��6E   $��297,152,0,0q�6Q   $
 Wrap=�6f   $��6��6z   $	��Top=�6�   $	��103��6�   ���	#FFC4EBFB6�   �� 5   
   -   5         ��Name$ RichTextBox_edges��5      $
��Left=�61   $	��174��6L   $��116,231,0,0q�6Y   $	��Top=�6n   $	��212��6�   $��0,1,1,1q�6�   ���	#FFC4EBFB. �5      /� .T�5      J� .*�6   .*�5      �� $�RichTextBox��6   5      5      5      5       5!      