﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PluralItem {


    public int Id { get; set; }

    public string Nome { get; set; }

    public string NomePlural { get; set; }

    public string Imagem { get; set; }

    public PluralItem(int id, string nome, string nomep, string imagem)
    {
        Id = id;

        Nome = nome;

        NomePlural = nomep;

        Imagem = imagem;
    }

    public bool Verificar(string n)
    {
        return n.Equals(this.NomePlural);
    }

}
