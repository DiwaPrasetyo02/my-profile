'use client';

import React, { useState } from 'react';

const InputName: React.FC = () => {
  const [inputValue, setInputValue] = useState<string>('');

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setInputValue(e.target.value);
  };

  return (
    <div style={{ padding: '20px', border: '1px solid #ccc', borderRadius: '8px', margin: '20px 0' }}>
      <h2>Input Teks disini...</h2>
      <input
        type="text"
        value={inputValue}
        onChange={handleChange}
        placeholder="Ketik teks di sini..."
        style={{
          padding: '10px',
          fontSize: '16px',
          width: '300px',
          borderRadius: '5px',
          border: '1px solid #ccc',
          marginBottom: '15px'
        }}
      />
      <p style={{ fontSize: '16px', color: '#333' }}>
        {inputValue || 'Teks akan muncul di sini...'}
      </p>
    </div>
  );
};

export default InputName;

