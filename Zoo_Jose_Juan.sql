PGDMP     
    3                {            Zoo_Jose_Juan    10.21    15.2 D    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    17666    Zoo_Jose_Juan    DATABASE     z   CREATE DATABASE "Zoo_Jose_Juan" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';
    DROP DATABASE "Zoo_Jose_Juan";
                postgres    false                        2615    2200    public    SCHEMA     2   -- *not* creating schema, since initdb creates it
 2   -- *not* dropping schema, since initdb creates it
                postgres    false            �           0    0    SCHEMA public    ACL     Q   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;
                   postgres    false    6            �            1259    17667    Empleado    TABLE     �   CREATE TABLE public."Empleado" (
    "Id_Empleado" integer NOT NULL,
    "Nombre" text NOT NULL,
    "Direccion" text,
    "Telefono" text NOT NULL,
    "Fecha_Ingreso" time without time zone NOT NULL,
    "Id_Tipo_Empleado" integer NOT NULL
);
    DROP TABLE public."Empleado";
       public            postgres    false    6            �            1259    17673    Empleado_Id_Empleado_seq    SEQUENCE     �   ALTER TABLE public."Empleado" ALTER COLUMN "Id_Empleado" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Empleado_Id_Empleado_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    6    196            �            1259    17675    Tipo_Empleado    TABLE     r   CREATE TABLE public."Tipo_Empleado" (
    "id_Tipo_Empleado" integer NOT NULL,
    "Nombre_Tipo" text NOT NULL
);
 #   DROP TABLE public."Tipo_Empleado";
       public            postgres    false    6            �            1259    17681    Empleado_id_Tipo_Empleado_seq    SEQUENCE     �   ALTER TABLE public."Tipo_Empleado" ALTER COLUMN "id_Tipo_Empleado" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Empleado_id_Tipo_Empleado_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    198    6            �            1259    17683    Especies    TABLE     �   CREATE TABLE public."Especies" (
    "Id_Especie" integer NOT NULL,
    "Nombre_Espanol" text NOT NULL,
    "Nombre_Cientifico" text NOT NULL,
    "Descripcion" text,
    "Id_Zona" integer NOT NULL
);
    DROP TABLE public."Especies";
       public            postgres    false    6            �            1259    17689    Especies_Empleados    TABLE     �   CREATE TABLE public."Especies_Empleados" (
    "Id_Especie_Empleado" integer NOT NULL,
    "Id_Especie" integer NOT NULL,
    "Id_Empleado" integer NOT NULL
);
 (   DROP TABLE public."Especies_Empleados";
       public            postgres    false    6            �            1259    17692 *   Especies_Empleados_Id_Especie_Empleado_seq    SEQUENCE       ALTER TABLE public."Especies_Empleados" ALTER COLUMN "Id_Especie_Empleado" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Especies_Empleados_Id_Especie_Empleado_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    201    6            �            1259    17694    Especies_Habitats    TABLE     �   CREATE TABLE public."Especies_Habitats" (
    "Id_Especie_Habitat" integer NOT NULL,
    "Id_Especie" integer NOT NULL,
    "Id_Habitat" integer NOT NULL
);
 '   DROP TABLE public."Especies_Habitats";
       public            postgres    false    6            �            1259    17697 (   Especies_Habitats_Id_Especie_Habitat_seq    SEQUENCE       ALTER TABLE public."Especies_Habitats" ALTER COLUMN "Id_Especie_Habitat" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Especies_Habitats_Id_Especie_Habitat_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    203    6            �            1259    17699    Especies_Id_Especie_seq    SEQUENCE     �   ALTER TABLE public."Especies" ALTER COLUMN "Id_Especie" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Especies_Id_Especie_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    200    6            �            1259    17701    Habitats    TABLE     �   CREATE TABLE public."Habitats" (
    "id_Habitat" integer NOT NULL,
    "Nombre" text NOT NULL,
    "Clima" integer,
    "Id_Tipo_Vegetacion" integer NOT NULL
);
    DROP TABLE public."Habitats";
       public            postgres    false    6            �            1259    17707    Habitats_id_Habitat_seq    SEQUENCE     �   ALTER TABLE public."Habitats" ALTER COLUMN "id_Habitat" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Habitats_id_Habitat_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    6    206            �            1259    17709 
   Itinerario    TABLE     -  CREATE TABLE public."Itinerario" (
    "Id_Itinerario" integer NOT NULL,
    "Codigo" text NOT NULL,
    "Fecha_Hora_Inicio" time without time zone NOT NULL,
    "Fecha_Hora_Fin" time without time zone NOT NULL,
    "Longitud_Itinerario" integer NOT NULL,
    "Maximo_Numero_Visitantes" integer NOT NULL,
    "Id_Empleado" integer NOT NULL,
    CONSTRAINT fecha_hora_inicio_menor_fecha_hora_fin CHECK (("Fecha_Hora_Inicio" < "Fecha_Hora_Fin")),
    CONSTRAINT not_null_itinerario CHECK ((("Codigo" IS NOT NULL) AND ("Fecha_Hora_Inicio" IS NOT NULL) AND ("Fecha_Hora_Fin" IS NOT NULL) AND ("Longitud_Itinerario" > 0) AND ("Maximo_Numero_Visitantes" > 0))),
    CONSTRAINT positive_longitud CHECK (("Longitud_Itinerario" > 0)),
    CONSTRAINT positive_max_num_visitantes CHECK (("Maximo_Numero_Visitantes" > 0))
);
     DROP TABLE public."Itinerario";
       public            postgres    false    6            �            1259    17715    Itinerario_Id_Itinerario_seq    SEQUENCE     �   ALTER TABLE public."Itinerario" ALTER COLUMN "Id_Itinerario" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Itinerario_Id_Itinerario_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    6    208            �            1259    17717    Tipo_Vegetacion    TABLE     �   CREATE TABLE public."Tipo_Vegetacion" (
    "Id_Tipo_Vegetacion" integer NOT NULL,
    "Nombre" text NOT NULL,
    "Descripcion" text
);
 %   DROP TABLE public."Tipo_Vegetacion";
       public            postgres    false    6            �            1259    17723 &   Tipo_Vegetacion_Id_Tipo_Vegetacion_seq    SEQUENCE     �   ALTER TABLE public."Tipo_Vegetacion" ALTER COLUMN "Id_Tipo_Vegetacion" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Tipo_Vegetacion_Id_Tipo_Vegetacion_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    6    210            �            1259    17725    Zonas    TABLE     z   CREATE TABLE public."Zonas" (
    "Id_Zona" integer NOT NULL,
    "Nombre_Zona" text NOT NULL,
    "Extencion" integer
);
    DROP TABLE public."Zonas";
       public            postgres    false    6            �            1259    17731    Zonas_Id_Zona_seq    SEQUENCE     �   ALTER TABLE public."Zonas" ALTER COLUMN "Id_Zona" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Zonas_Id_Zona_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    212    6            �          0    17667    Empleado 
   TABLE DATA           {   COPY public."Empleado" ("Id_Empleado", "Nombre", "Direccion", "Telefono", "Fecha_Ingreso", "Id_Tipo_Empleado") FROM stdin;
    public          postgres    false    196   �V       �          0    17683    Especies 
   TABLE DATA           s   COPY public."Especies" ("Id_Especie", "Nombre_Espanol", "Nombre_Cientifico", "Descripcion", "Id_Zona") FROM stdin;
    public          postgres    false    200   Z       �          0    17689    Especies_Empleados 
   TABLE DATA           b   COPY public."Especies_Empleados" ("Id_Especie_Empleado", "Id_Especie", "Id_Empleado") FROM stdin;
    public          postgres    false    201   KZ       �          0    17694    Especies_Habitats 
   TABLE DATA           _   COPY public."Especies_Habitats" ("Id_Especie_Habitat", "Id_Especie", "Id_Habitat") FROM stdin;
    public          postgres    false    203   �Z       �          0    17701    Habitats 
   TABLE DATA           [   COPY public."Habitats" ("id_Habitat", "Nombre", "Clima", "Id_Tipo_Vegetacion") FROM stdin;
    public          postgres    false    206   �Z       �          0    17709 
   Itinerario 
   TABLE DATA           �   COPY public."Itinerario" ("Id_Itinerario", "Codigo", "Fecha_Hora_Inicio", "Fecha_Hora_Fin", "Longitud_Itinerario", "Maximo_Numero_Visitantes", "Id_Empleado") FROM stdin;
    public          postgres    false    208   [       �          0    17675    Tipo_Empleado 
   TABLE DATA           L   COPY public."Tipo_Empleado" ("id_Tipo_Empleado", "Nombre_Tipo") FROM stdin;
    public          postgres    false    198   �[       �          0    17717    Tipo_Vegetacion 
   TABLE DATA           Z   COPY public."Tipo_Vegetacion" ("Id_Tipo_Vegetacion", "Nombre", "Descripcion") FROM stdin;
    public          postgres    false    210   $\       �          0    17725    Zonas 
   TABLE DATA           H   COPY public."Zonas" ("Id_Zona", "Nombre_Zona", "Extencion") FROM stdin;
    public          postgres    false    212   �\       �           0    0    Empleado_Id_Empleado_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Empleado_Id_Empleado_seq"', 71, true);
          public          postgres    false    197            �           0    0    Empleado_id_Tipo_Empleado_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public."Empleado_id_Tipo_Empleado_seq"', 33, true);
          public          postgres    false    199            �           0    0 *   Especies_Empleados_Id_Especie_Empleado_seq    SEQUENCE SET     [   SELECT pg_catalog.setval('public."Especies_Empleados_Id_Especie_Empleado_seq"', 18, true);
          public          postgres    false    202            �           0    0 (   Especies_Habitats_Id_Especie_Habitat_seq    SEQUENCE SET     X   SELECT pg_catalog.setval('public."Especies_Habitats_Id_Especie_Habitat_seq"', 1, true);
          public          postgres    false    204            �           0    0    Especies_Id_Especie_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."Especies_Id_Especie_seq"', 1, true);
          public          postgres    false    205            �           0    0    Habitats_id_Habitat_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Habitats_id_Habitat_seq"', 19, true);
          public          postgres    false    207            �           0    0    Itinerario_Id_Itinerario_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."Itinerario_Id_Itinerario_seq"', 9, true);
          public          postgres    false    209            �           0    0 &   Tipo_Vegetacion_Id_Tipo_Vegetacion_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public."Tipo_Vegetacion_Id_Tipo_Vegetacion_seq"', 22, true);
          public          postgres    false    211            �           0    0    Zonas_Id_Zona_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Zonas_Id_Zona_seq"', 35, true);
          public          postgres    false    213            E           2606    17734    Tipo_Empleado Empleado_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."Tipo_Empleado"
    ADD CONSTRAINT "Empleado_pkey" PRIMARY KEY ("id_Tipo_Empleado");
 I   ALTER TABLE ONLY public."Tipo_Empleado" DROP CONSTRAINT "Empleado_pkey";
       public            postgres    false    198            B           2606    17736    Empleado Empleado_pkey1 
   CONSTRAINT     d   ALTER TABLE ONLY public."Empleado"
    ADD CONSTRAINT "Empleado_pkey1" PRIMARY KEY ("Id_Empleado");
 E   ALTER TABLE ONLY public."Empleado" DROP CONSTRAINT "Empleado_pkey1";
       public            postgres    false    196            J           2606    17738 *   Especies_Empleados Especies_Empleados_pkey 
   CONSTRAINT        ALTER TABLE ONLY public."Especies_Empleados"
    ADD CONSTRAINT "Especies_Empleados_pkey" PRIMARY KEY ("Id_Especie_Empleado");
 X   ALTER TABLE ONLY public."Especies_Empleados" DROP CONSTRAINT "Especies_Empleados_pkey";
       public            postgres    false    201            L           2606    17740 (   Especies_Habitats Especies_Habitats_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public."Especies_Habitats"
    ADD CONSTRAINT "Especies_Habitats_pkey" PRIMARY KEY ("Id_Especie_Habitat");
 V   ALTER TABLE ONLY public."Especies_Habitats" DROP CONSTRAINT "Especies_Habitats_pkey";
       public            postgres    false    203            G           2606    17742    Especies Especies_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Especies"
    ADD CONSTRAINT "Especies_pkey" PRIMARY KEY ("Id_Especie");
 D   ALTER TABLE ONLY public."Especies" DROP CONSTRAINT "Especies_pkey";
       public            postgres    false    200            P           2606    17744    Habitats Habitats_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Habitats"
    ADD CONSTRAINT "Habitats_pkey" PRIMARY KEY ("id_Habitat");
 D   ALTER TABLE ONLY public."Habitats" DROP CONSTRAINT "Habitats_pkey";
       public            postgres    false    206            S           2606    17746    Itinerario Itinerario_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public."Itinerario"
    ADD CONSTRAINT "Itinerario_pkey" PRIMARY KEY ("Id_Itinerario");
 H   ALTER TABLE ONLY public."Itinerario" DROP CONSTRAINT "Itinerario_pkey";
       public            postgres    false    208            X           2606    17748 $   Tipo_Vegetacion Tipo_Vegetacion_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public."Tipo_Vegetacion"
    ADD CONSTRAINT "Tipo_Vegetacion_pkey" PRIMARY KEY ("Id_Tipo_Vegetacion");
 R   ALTER TABLE ONLY public."Tipo_Vegetacion" DROP CONSTRAINT "Tipo_Vegetacion_pkey";
       public            postgres    false    210            Z           2606    17750    Zonas Zonas_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public."Zonas"
    ADD CONSTRAINT "Zonas_pkey" PRIMARY KEY ("Id_Zona");
 >   ALTER TABLE ONLY public."Zonas" DROP CONSTRAINT "Zonas_pkey";
       public            postgres    false    212            V           2606    17989 *   Itinerario unq_itinerarios_guia_fecha_hora 
   CONSTRAINT     �   ALTER TABLE ONLY public."Itinerario"
    ADD CONSTRAINT unq_itinerarios_guia_fecha_hora UNIQUE ("Id_Empleado", "Fecha_Hora_Inicio", "Fecha_Hora_Fin", "Codigo");
 V   ALTER TABLE ONLY public."Itinerario" DROP CONSTRAINT unq_itinerarios_guia_fecha_hora;
       public            postgres    false    208    208    208    208            T           1259    17751    fki_Fk_Empleado    INDEX     S   CREATE INDEX "fki_Fk_Empleado" ON public."Itinerario" USING btree ("Id_Empleado");
 %   DROP INDEX public."fki_Fk_Empleado";
       public            postgres    false    208            M           1259    17752    fki_Fk_Especie    INDEX     X   CREATE INDEX "fki_Fk_Especie" ON public."Especies_Habitats" USING btree ("Id_Especie");
 $   DROP INDEX public."fki_Fk_Especie";
       public            postgres    false    203            N           1259    17753    fki_Fk_Habitat    INDEX     X   CREATE INDEX "fki_Fk_Habitat" ON public."Especies_Habitats" USING btree ("Id_Habitat");
 $   DROP INDEX public."fki_Fk_Habitat";
       public            postgres    false    203            C           1259    17754    fki_Fk_Tipo_Empleado    INDEX     [   CREATE INDEX "fki_Fk_Tipo_Empleado" ON public."Empleado" USING btree ("Id_Tipo_Empleado");
 *   DROP INDEX public."fki_Fk_Tipo_Empleado";
       public            postgres    false    196            Q           1259    17755    fki_Fk_Tipo_Vegetacion    INDEX     _   CREATE INDEX "fki_Fk_Tipo_Vegetacion" ON public."Habitats" USING btree ("Id_Tipo_Vegetacion");
 ,   DROP INDEX public."fki_Fk_Tipo_Vegetacion";
       public            postgres    false    206            H           1259    17756    fki_Fk_Zona    INDEX     I   CREATE INDEX "fki_Fk_Zona" ON public."Especies" USING btree ("Id_Zona");
 !   DROP INDEX public."fki_Fk_Zona";
       public            postgres    false    200            d           2606    17757    Itinerario Fk_Empleado    FK CONSTRAINT     �   ALTER TABLE ONLY public."Itinerario"
    ADD CONSTRAINT "Fk_Empleado" FOREIGN KEY ("Id_Empleado") REFERENCES public."Empleado"("Id_Empleado") NOT VALID;
 D   ALTER TABLE ONLY public."Itinerario" DROP CONSTRAINT "Fk_Empleado";
       public          postgres    false    2882    196    208            ]           2606    17762    Especies_Empleados Fk_Empleado    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies_Empleados"
    ADD CONSTRAINT "Fk_Empleado" FOREIGN KEY ("Id_Empleado") REFERENCES public."Empleado"("Id_Empleado") NOT VALID;
 L   ALTER TABLE ONLY public."Especies_Empleados" DROP CONSTRAINT "Fk_Empleado";
       public          postgres    false    196    2882    201            a           2606    17767    Especies_Habitats Fk_Especie    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies_Habitats"
    ADD CONSTRAINT "Fk_Especie" FOREIGN KEY ("Id_Especie") REFERENCES public."Especies"("Id_Especie") NOT VALID;
 J   ALTER TABLE ONLY public."Especies_Habitats" DROP CONSTRAINT "Fk_Especie";
       public          postgres    false    2887    200    203            ^           2606    17772    Especies_Empleados Fk_Especie    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies_Empleados"
    ADD CONSTRAINT "Fk_Especie" FOREIGN KEY ("Id_Especie") REFERENCES public."Especies"("Id_Especie") NOT VALID;
 K   ALTER TABLE ONLY public."Especies_Empleados" DROP CONSTRAINT "Fk_Especie";
       public          postgres    false    2887    200    201            b           2606    17777    Especies_Habitats Fk_Habitat    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies_Habitats"
    ADD CONSTRAINT "Fk_Habitat" FOREIGN KEY ("Id_Habitat") REFERENCES public."Habitats"("id_Habitat") NOT VALID;
 J   ALTER TABLE ONLY public."Especies_Habitats" DROP CONSTRAINT "Fk_Habitat";
       public          postgres    false    203    2896    206            [           2606    17782    Empleado Fk_Tipo_Empleado    FK CONSTRAINT     �   ALTER TABLE ONLY public."Empleado"
    ADD CONSTRAINT "Fk_Tipo_Empleado" FOREIGN KEY ("Id_Tipo_Empleado") REFERENCES public."Tipo_Empleado"("id_Tipo_Empleado") NOT VALID;
 G   ALTER TABLE ONLY public."Empleado" DROP CONSTRAINT "Fk_Tipo_Empleado";
       public          postgres    false    196    2885    198            c           2606    17787    Habitats Fk_Tipo_Vegetacion    FK CONSTRAINT     �   ALTER TABLE ONLY public."Habitats"
    ADD CONSTRAINT "Fk_Tipo_Vegetacion" FOREIGN KEY ("Id_Tipo_Vegetacion") REFERENCES public."Tipo_Vegetacion"("Id_Tipo_Vegetacion") NOT VALID;
 I   ALTER TABLE ONLY public."Habitats" DROP CONSTRAINT "Fk_Tipo_Vegetacion";
       public          postgres    false    2904    210    206            \           2606    17792    Especies Fk_Zona    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies"
    ADD CONSTRAINT "Fk_Zona" FOREIGN KEY ("Id_Zona") REFERENCES public."Zonas"("Id_Zona") NOT VALID;
 >   ALTER TABLE ONLY public."Especies" DROP CONSTRAINT "Fk_Zona";
       public          postgres    false    212    2906    200            _           2606    18001    Especies_Empleados fk_empleado    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies_Empleados"
    ADD CONSTRAINT fk_empleado FOREIGN KEY ("Id_Empleado") REFERENCES public."Empleado"("Id_Empleado");
 J   ALTER TABLE ONLY public."Especies_Empleados" DROP CONSTRAINT fk_empleado;
       public          postgres    false    2882    201    196            `           2606    17996    Especies_Empleados fk_especie    FK CONSTRAINT     �   ALTER TABLE ONLY public."Especies_Empleados"
    ADD CONSTRAINT fk_especie FOREIGN KEY ("Id_Especie") REFERENCES public."Especies"("Id_Especie");
 I   ALTER TABLE ONLY public."Especies_Empleados" DROP CONSTRAINT fk_especie;
       public          postgres    false    201    2887    200            �   2  x�����IE��W�
|�#3lgX`�MdOÐ��y��MRʇ�<�.�K�������|��;_.����|��)>�B\<Z�6nx�B�p#����}����_ۗ�������j]D���J�J���~uo�a�z�>�O����v�y-=?Y����*nt�����r˿�|u��ʜ���[fc/��&�8�K������������������Ho>�FqƠf'�#(�Q��Ҝ8��5� Q��h�S �i53�>��5JB>�l��F��E�`
�5k���1��"W(�%���*IQ����@�Ă*����� q.*���bl45LM��TXv���TS���TI�L5�5'i���VT�ލ�t�1�TQ9)�����P��GM&[t�+�xP�:j�MU��s��A΍�k$�k��T�N��c1>�U�ƃ���¼\�/�z��9E�5�b�՛T�N�(�w�'U�ƃ�@1���A������	��)��*8#��d4_�hIU�!)�&,3�D*���L�{�\�R����>%�1&R�8(^(Ue������(ݹ��Z+<��������f>���S�~�n7-v�����Z�ſ�܃��*���m�Ykr)�w�3�ZӚ\A�&���Er܇��'�T�*�:)_���JϲZ��X������Z�dm�4�Z1��/mh��PP�w�/�`cj�e�w�J�G����q�h�3�l|eY{0@���/y��Z�e>�83����$��8V|��xP����4:n�_^�������?l����۷��z|�I�X7��-����p�`�@`      �      x�3�tI�I�̃Q��
)�!W� ��	'      �   =   x�%̹�0���#��Ļd�9��S%�h�F�q����7����x�?��	l`��U���%      �      x������ � �      �   Z   x�uй�0�x�
W��st@$k�!�?L����������~���b�L0��`!X	6��@#�P0^X/����������      �   X   x�M�A
� D���W�ڶ(h���9RRf�`��:6�����《�b��-����~*۽��<���ZC�|���:��xy�      �   �   x�}л�@���
W`���W !ɂ7��t�eQ�!Q�d#M�y9��;��rZ���Z.K{s�l���߭�y�hni�h�ihi���^Trdrtr�r�r�r�Z	��VB+���Jh%�Z	�*ZU��hU��:���:.      �   �   x�3�KMO-IL�<�9�3$� _!%U�!�eE�((*MMJ�#�eL�>2����όL}�d� S�%����hH�Fr��!�iƐ�DcHn�1$7���n�M8���|U�Z�\�Y������&#C�ƒ�b���� H��      �   �   x�m�1�@C�z�9A����&(�J���L�nǿy�"���2��h-�?�>|��?��Ɠ'7��8�m�v=/�_#Z���Y*J��0�Yf5K�,��Bk�,��Bk�,��R�R���BY�ZJ�ǘ�?���;     