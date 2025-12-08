'use client';

import React, { useState } from 'react';

const Counter: React.FC = () => {
  const [count, setCount] = useState<number>(0);

  const increment = () => {
    setCount(count + 1);
  };

  const decrement = () => {
    setCount(count - 1);
  };

  return (
    <div style={{ padding: '20px', border: '1px solid #ccc', borderRadius: '8px', margin: '20px 0' }}>
      <h2>Counter</h2>
      <div style={{ display: 'flex', alignItems: 'center', gap: '15px' }}>
        <button 
          onClick={decrement}
          style={{
            padding: '10px 20px',
            fontSize: '18px',
            backgroundColor: '#f44336',
            color: 'white',
            border: 'none',
            borderRadius: '5px',
            cursor: 'pointer'
          }}
        >
          -
        </button>
        <span style={{ fontSize: '24px', fontWeight: 'bold', minWidth: '50px', textAlign: 'center' }}>
          {count}
        </span>
        <button 
          onClick={increment}
          style={{
            padding: '10px 20px',
            fontSize: '18px',
            backgroundColor: '#4caf50',
            color: 'white',
            border: 'none',
            borderRadius: '5px',
            cursor: 'pointer'
          }}
        >
          +
        </button>
      </div>
    </div>
  );
};

export default Counter;

