import { test, expect } from '@playwright/test';

test('test', async ({ page }) => {
  await page.goto('http://localhost:8181/');
  await page.getByRole('link', { name: 'Calculadora' }).click();
  await page.getByRole('button', { name: '9' }).click();
  await page.getByRole('button', { name: '8' }).click();
  await page.getByRole('button', { name: '7' }).click();
  await page.getByRole('button', { name: '4' }).click();
  await page.getByRole('button', { name: '5' }).click();
  await page.getByRole('button', { name: '6' }).click();
  await page.getByRole('button', { name: '3' }).click();
  await page.getByRole('button', { name: '2' }).click();
  await page.getByRole('button', { name: '1' }).click();
  await page.getByRole('button', { name: '0' }).click();
  await page.getByText('9874563210').click({
    button: 'right'
  });
  await page.getByText('9874563210').click();
});