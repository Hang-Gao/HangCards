   M S B A M L   `   `   `  ���� H  DHangCards GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangCards_GUIHangCards_GUI      HangCards_GUI.GameClient   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     +srcclr-namespace:HangCards_GUI       � Title$  Hang Cards Game Client�� � WindowState$ 	Maximized=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$ ApplicationCommands.Close��  -   $ ApplicationCommands.Save��.��� 
��� � � � RowDefinitions �� $��58 ��� $��20 ��� �� $��42 �.+��� $��0�����#C40D42.+��� $��56�� �� Left$ 0��
 �� Top$ 0��$��UniformToFill=�$��.\Images\Banner.png���� $��
Hang Cards�� �� Right$ 10��$ 13�����	#FFF7EFEF$��Times New Roman)�$��24(�$
��Bold"�]� $��1��$��0q�.+�o� $��20��$	��Top=�
���   �$
��Bold"�
�������.@�m� $��_File��
�������.@�m� $��_New Game...��$��22��$	��200��
���   �m� $��_Open��$	��200��
���   �m� $��_Save��$	��200��
���   � m� Command$
 Save��	 m� Icon	 �� $%��.\Images\base_floppydisk_32.png��$��20���� $	��145��
���   �m� $��_Close��$	��200��
���   �$ Close��m� $��_Game��
���   �
�������.@�m� $��_Undo��$
��Left=�$	��145��
���   �m� $��_Tool��
���   �
�������.@�m� $��_Options��$
��Left=�$	��145��
���   �m� $��_Help��
���   �
�������.@�m� $��_About��$
��Left=�$	��145��
���   �� -   
 �Name$
 contentGrid��$��2��