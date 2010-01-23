﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IronJS.Tests.Builtins
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestArray_ctor()
        {
            ScriptRunner.Run(
                @"
                var boo = Array(2);
                assertEqual(2, boo.length, 'boo.length should be 2');

                var baz = new Array(3);
                assertEqual(3, baz.length, 'baz.length should be 3');

                var foo = Array('x', 'y', 'z');
                buffer = '';
                for(i = 0; i < foo.length; ++i) { buffer += foo[i]; }
                assertEqual('xyz', buffer, 'buffer should equal \'xyz\'');

                var bar = new Array('a', 'b', 'c');
                buffer = '';
                for(i = 0; i < bar.length; ++i) { buffer += bar[i]; }
                assertEqual('abc', buffer, 'buffer should equal \'abc\'');
                "
            );
        }

        [TestMethod]
        public void TestArray_prototype_concat()
        {
            ScriptRunner.Run(
                @"
                foo = [1, 2, 3];
                bar = foo.concat(4, [5, 6, 7], 'foo', 9);

                buffer = '';
                for(i = 0; i < bar.length; ++i) {
                    buffer += bar[i];
                }

                assertEqual('1234567foo9', buffer, 'buffer should equal \'1234567foo9\'');
                assertFalse(foo == bar, 'foo should not equal bar');
                assertEqual(9, bar.length, 'bar.length should be 9');
                assertTrue(8 in bar, 'bar should have key 8');
                assertFalse(9 in bar, 'bar should nto have key 9');
                "
            );
        }

        [TestMethod]
        public void TestArray_prototype_join()
        {
            ScriptRunner.Run(
                @"
                foo = ['a', 'b', 'c', 1, 2, 3];

                assertEqual('a,b,c,1,2,3', foo.join(','), 'foo.join(,) should equal a,b,c,1,2,3');
                assertEqual(foo.join(','), foo.join(), 'foo.join(,) should equal foo.join()');
                assertEqual('a--b--c--1--2--3', foo.join('--'), 'foo.join(--) should equal a--b--c--1--2--3');
                "
            );
        }

        [TestMethod]
        public void TestArray_prototype_pop()
        {
            ScriptRunner.Run(
                @"
                foo = ['a', 'b', 'c'];

                assertEqual(3, foo.length, 'foo.length is 3');

                assertEqual('c', foo.pop(), 'foo.pop() returns c');
                assertEqual(2, foo.length, 'foo.length is 2');

                assertEqual('b', foo.pop(), 'foo.pop() returns b');
                assertEqual(1, foo.length, 'foo.length is 1');

                assertEqual('a', foo.pop(), 'foo.pop() returns a');
                assertEqual(0, foo.length, 'foo.length is 0');

                assertEqual(undefined, foo.pop(), 'foo.pop() returns undefined');
                assertEqual(0, foo.length, 'foo.length is 0');
                "
            );
        }

        [TestMethod]
        public void TestArray_prototype_push()
        {
            ScriptRunner.Run(
                @"
                foo = ['a', 'b', 'c'];

                assertEqual(3, foo.length, 'foo.length is 3');
                
                foo.push('d');
                assertEqual(4, foo.length, 'foo.length is 4');
                
                foo.push('e', 'f');
                assertEqual(6, foo.length, 'foo.length is 6');

                assertEqual('abcdef', foo.join(''), 'foo.join(\'\') is abcdef');
                "
            );
        }

    }
}
