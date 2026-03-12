using System;
using System.Collections.Generic;
using System.Text;

class Converter<TInput, TOutput>
{
    private Func<TInput, TOutput> _convertFunc;
    public Converter(Func<TInput, TOutput> convertfunc)
    {
        _convertFunc = convertfunc;
    }
    public TOutput Convert(TInput input)
    {
        return _convertFunc(input);
    }
    public TOutput[] ConvertAll(TInput[] inputs)
    {
        if (inputs == null) return null;

        TOutput[] temp = new TOutput[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            temp[i] = Convert(inputs[i]);
        }
        return temp;
    }
}