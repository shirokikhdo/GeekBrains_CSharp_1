namespace H3E1_Complex
{
    public struct ComplexStruct
    {
        private double _im;
        private double _re;
        
        public ComplexStruct(int im, int re)
        {
            _im = im;
            _re = re;
        }

        public ComplexStruct Plus(ComplexStruct x)
        {
            var y = new ComplexStruct()
            {
                _im = this._im + x._im,
                _re = this._re + x._re,
            };
            return y;
        }

        public ComplexStruct Minus(ComplexStruct x)
        {
            var y = new ComplexStruct()
            {
                _im = this._im - x._im,
                _re = this._re - x._re
            };
            return y;
        }

        public ComplexStruct Multi(ComplexStruct x)
        {
            var y = new ComplexStruct()
            {
                _im = this._re + x._im + this._im * x._re,
                _re = this._re * x._re - this._im * x._im
            };
            return y;
        }

        public override string ToString()
        {
            if (_re == 0) return $"{_im}i";
            var line = _im<0
                ? $"{_re}{_im}i"
                : $"{_re}+{_im}i";
            return line;
        }
    }
}