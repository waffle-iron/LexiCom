/*
 * SyntaxConstants.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

namespace Syntax_Analyzer {

    /**
     * <remarks>An enumeration with token and production node
     * constants.</remarks>
     */
    public enum SyntaxConstants {
        TASK = 1001,
        LEAD = 1002,
        START = 1003,
        END = 1004,
        VAR = 1005,
        ID = 1006,
        AS = 1007,
        LET = 1008,
        OBJECT = 1009,
        OF = 1010,
        BY = 1011,
        IS = 1012,
        CLEAR = 1013,
        READ = 1014,
        SAY = 1015,
        SKIP = 1016,
        STOP = 1017,
        IF = 1018,
        OR = 1019,
        OTHERWISE = 1020,
        OPTION = 1021,
        STATE = 1022,
        DEFAULT = 1023,
        UNTIL = 1024,
        LOOP = 1025,
        LOOPIF = 1026,
        DO = 1027,
        FOR = 1028,
        RESPONSE = 1029,
        ENDIF = 1030,
        INT = 1031,
        DOUBLE = 1032,
        CHAR = 1033,
        STRING = 1034,
        NULL = 1035,
        ARRAY = 1036,
        BOOLEAN = 1037,
        INTLIT = 1038,
        DOUBLELIT = 1039,
        CHARLIT = 1040,
        STRINGLIT = 1041,
        BOOLLIT = 1042,
        COL = 1043,
        SEM = 1044,
        DIE = 1045,
        PER = 1046,
        OP = 1047,
        CP = 1048,
        OB = 1049,
        CB = 1050,
        ADD = 1051,
        MIN = 1052,
        MUL = 1053,
        DIV = 1054,
        MOD = 1055,
        INC = 1056,
        DEC = 1057,
        ISEQ = 1058,
        NOTEQ = 1059,
        GREAT = 1060,
        LESS = 1061,
        LOGAND = 1062,
        LOGOR = 1063,
        NOT = 1064,
        EQ = 1065,
        COMMA = 1066,
        AT = 1067,
        GEQ = 1068,
        LEQ = 1069,
        WHITESPACE = 1070,
        PROD_START_PROGRAM = 2001,
        PROD_PROGRAM = 2002,
        PROD_GLOBAL = 2003,
        PROD_GLOBAL_CHOICE = 2004,
        PROD_DTYPE = 2005,
        PROD_OBJECT = 2006,
        PROD_OBJDEC_CHOICE = 2007,
        PROD_VAR = 2008,
        PROD_OBJVAR = 2009,
        PROD_VARNAME = 2010,
        PROD_VARNAMES = 2011,
        PROD_TASK = 2012,
        PROD_RETURN = 2013,
        PROD_TPARAM = 2014,
        PROD_TPARAMS = 2015,
        PROD_ARRAY = 2016,
        PROD_SIZE = 2017,
        PROD_SIZES = 2018,
        PROD_VARLET = 2019,
        PROD_VARDEC = 2020,
        PROD_VAR_INT = 2021,
        PROD_INIT_INT = 2022,
        PROD_VAR_DOUBLE = 2023,
        PROD_INIT_DOUBLE = 2024,
        PROD_VAR_CHAR = 2025,
        PROD_INIT_CHAR = 2026,
        PROD_VAR_STRING = 2027,
        PROD_INIT_STRING = 2028,
        PROD_VAR_BOOLEAN = 2029,
        PROD_INIT_BOOLEAN = 2030,
        PROD_IDS1 = 2031,
        PROD_IDS2 = 2032,
        PROD_IDS3 = 2033,
        PROD_IDS4 = 2034,
        PROD_IDS5 = 2035,
        PROD_IDS1_TAIL = 2036,
        PROD_IDS2_TAIL = 2037,
        PROD_IDS3_TAIL = 2038,
        PROD_IDS4_TAIL = 2039,
        PROD_IDS5_TAIL = 2040,
        PROD_VALUE1 = 2041,
        PROD_VALUE2 = 2042,
        PROD_VALUE3 = 2043,
        PROD_VALUE4 = 2044,
        PROD_VALUE5 = 2045,
        PROD_NUMVALUE = 2046,
        PROD_NUMELEMENT = 2047,
        PROD_OPERATIONS1 = 2048,
        PROD_OP_INT = 2049,
        PROD_OP1 = 2050,
        PROD_DOUBLEVALUE = 2051,
        PROD_OPERATIONS2 = 2052,
        PROD_OP_DOUBLE = 2053,
        PROD_OP2 = 2054,
        PROD_MATH_OP = 2055,
        PROD_INCDEC = 2056,
        PROD_RELOP1 = 2057,
        PROD_LOGOP1 = 2058,
        PROD_LOGOP2 = 2059,
        PROD_BODY = 2060,
        PROD_STATEMENTS = 2061,
        PROD_FUNCTIONS = 2062,
        PROD_ID_CHOICES = 2063,
        PROD_SUBELEMENT_CHOICE = 2064,
        PROD_VARINIT = 2065,
        PROD_VARINIT_INT = 2066,
        PROD_VARINIT_DOUBLE = 2067,
        PROD_VARINIT_CHAR = 2068,
        PROD_VARINIT_STRING = 2069,
        PROD_VARINIT_BOOLEAN = 2070,
        PROD_INT = 2071,
        PROD_DOUBLE = 2072,
        PROD_CHAR = 2073,
        PROD_STRING = 2074,
        PROD_BOOLEAN = 2075,
        PROD_TASK_ID = 2076,
        PROD_PARAM = 2077,
        PROD_PARAMS = 2078,
        PROD_VALUE = 2079,
        PROD_IO_STATEMENT = 2080,
        PROD_INPUT = 2081,
        PROD_OUTPUT = 2082,
        PROD_INPUT_STATEMENT = 2083,
        PROD_CONCAT = 2084,
        PROD_CONCAT_VALUE = 2085,
        PROD_SUBELEMENT = 2086,
        PROD_INPUT_ID = 2087,
        PROD_MULTI = 2088,
        PROD_INDEX = 2089,
        PROD_IF_OTHERWISE = 2090,
        PROD_OR = 2091,
        PROD_OTHERWISE = 2092,
        PROD_COND_LOOP = 2093,
        PROD_CONTROL = 2094,
        PROD_CONDITIONS = 2095,
        PROD_MULTICONDS = 2096,
        PROD_IDS = 2097,
        PROD_IDS_NULL = 2098,
        PROD_CONDS_TAIL = 2099,
        PROD_LOG_OPS = 2100,
        PROD_REL_OPS = 2101,
        PROD_RELOP_NUM = 2102,
        PROD_RELOP_TEXT = 2103,
        PROD_NUMVAL = 2104,
        PROD_OPTION = 2105,
        PROD_OPTIONTAILS = 2106,
        PROD_OPTIONTAIL1 = 2107,
        PROD_OPTIONTAIL2 = 2108,
        PROD_OPTIONTAIL3 = 2109,
        PROD_STATE1 = 2110,
        PROD_STATE2 = 2111,
        PROD_STATE3 = 2112,
        PROD_DEFAULT = 2113,
        PROD_INCDECVAR = 2114,
        PROD_LOOPSTATE = 2115,
        PROD_INITIALIZE = 2116,
        PROD_COND = 2117,
        PROD_TASKDEF = 2118,
        PROD_RETURNTYPE = 2119,
        PROD_TASKBODY = 2120,
        PROD_RETURN_INT = 2121,
        PROD_RETURN_DOUBLE = 2122,
        PROD_RETURN_CHAR = 2123,
        PROD_RETURN_STRING = 2124,
        PROD_RETURN_BOOLEAN = 2125,
        PROD_RETURNTAIL = 2126
    }
}
