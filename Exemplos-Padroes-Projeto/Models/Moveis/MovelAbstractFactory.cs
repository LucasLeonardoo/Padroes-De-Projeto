﻿//  MovelAbstractFactory.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using ExemplosPadroesProjeto.Models.Moveis;
using System;
namespace ExemplosPadrõesProjeto.Models.Moveis
{
    public abstract class MovelAbstractFactory
    {

        public Movel CriarMovel(MovelEnum movel)
        {
            switch (movel)
            {
                case MovelEnum.Cadeira:
                    return CriarCadeira();
                case MovelEnum.Mesa:
                    return CriarMesa();
                case MovelEnum.Armario:
                    return CriarArmario();
                case MovelEnum.Escrivaninha:
                    return CriarEscrivaninha();
                default:
                    return null;
            }
        }

        protected abstract Mesa CriarMesa();


        protected abstract Cadeira CriarCadeira();

        protected abstract Armario CriarArmario();

        protected abstract Escrivaninha CriarEscrivaninha();

        public MovelAbstractFactory()
        {
        }



        public static MovelAbstractFactory CriarInstancia(EstiloEnum Estilo)
        {
            switch (Estilo)
            {
                case EstiloEnum.Barroco:
                    return new MovelBarrocoFactory();
                case EstiloEnum.Futurista:
                    return new MovelFuturistaFactory();
                case EstiloEnum.Rustico:
                    return new MovelRusticoFactory();
                default:
                    throw new NotSupportedException("Estilo não especificado!");
            }
        }
    }
}
