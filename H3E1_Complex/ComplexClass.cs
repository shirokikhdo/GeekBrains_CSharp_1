namespace H3E1_Complex
{
    public class ComplexClass
    {
        private int _im;
        private int _re;

        public ComplexClass()
        {

        }

        public ComplexClass(int im, int re)
        {
            _im = im;
            _re = re;
        }

        public ComplexClass Plus(ComplexClass x)
        {
            var y = new ComplexClass()
            {
                _im = this._im + x._im,
                _re = this._re + x._re,
            };
            return y;
        }

        public ComplexClass Minus(ComplexClass x)
        {
            var y = new ComplexClass()
            {
                _im = this._im - x._im,
                _re = this._re - x._re
            };
            return y;
        }

        public ComplexClass Multi(ComplexClass x)
        {
            var y = new ComplexClass()
            {
                _im = this._re + x._im + this._im * x._re,
                _re = this._re * x._re - this._im * x._im
            };
            return y;
        }

        public override string ToString()
        {
            if (_re == 0) return $"{_im}i";
            var line = _im < 0
                ? $"{_re}{_im}i"
                : $"{_re}+{_im}i";
            return line;
        }
    }
}