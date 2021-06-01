using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionDataBase
{
    public class Commands
    {
        private Dictionary<string, object> _params;
        private bool _stored;
        private string _query;
        private int? _returnValue;

        public Commands(string query, bool isStoredProcedure = false)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException("Query can't be null");
            }
            _query = query;
            _stored = isStoredProcedure;
            _params = new Dictionary<string, object>();
        }
        public int? ReturnValue
        {
            get
            {
                if (!Stored)
                {
                    throw new InvalidOperationException("Only When a stored procedure");
                }
                return _returnValue;
            }
            internal set
            {
                _returnValue = value;
            }
        }

        public Dictionary<string, object> Params
        {
            get
            {
                return _params;
            }
        }

        public bool Stored
        {
            get
            {
                return _stored;
            }
        }

        public string Query
        {
            get
            {
                return _query;
            }

        }

        public void AddParameter(string parameterName, object value)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                throw new ArgumentNullException("Parameter can't be null");
            }

            _params.Add(parameterName, value ?? DBNull.Value);
        }
    }
}
